using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;
using CsvHelper;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var filename = @"D:\temp\action_windows-6axis\action_data_1.csv";

            StreamReader reader = new StreamReader(filename);
            string line = "";
            List<string[]> listStrArr = new List<string[]>();
            line = reader.ReadLine();
            while (line != null)
            {
                //Console.WriteLine(line);
                listStrArr.Add(line.Split(','));
                line = reader.ReadLine();
            }
            foreach(var ii in listStrArr)
            {
                foreach(var jj in ii)
                {
                    Console.WriteLine(jj);
                }
                
            }
            //Console.WriteLine(listStrArr);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var filename = @"D:\temp\action_windows-6axis\action_data_1.csv";

            StreamReader SRFile = new StreamReader(filename);
            var csv = new CsvHelper.CsvReader(SRFile, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<SensorData>().ToList();
            SRFile.Close();  //关闭文件

            List<double> df = new List<double>();

            foreach (var data in records)
            {
                df.AddRange(data.getSensorDataList());
            }


            double[] df1 = df.ToArray();
            //Console.WriteLine(df1.Length);
            var df2 = np.array(df1);
            Shape newshape = ((df1.Length/43), 43);
            //Console.WriteLine((string)dad);
            var dataMat = df2.reshape(newshape);
            Console.WriteLine(dataMat.Shape);
            //Console.WriteLine((string)dataMat[":,-1"].reshape(-1,1));

            int i = 0;
            while (i < dataMat.size)
            {
                i++;
                Console.WriteLine((string)dataMat[i]);

                if (i > 5)
                {
                    break;
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> a = new List<int> { 1,2,3};
            List<int> b = new List<int> { 4,5,6};
            a.AddRange(b);
            
            foreach(var s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
