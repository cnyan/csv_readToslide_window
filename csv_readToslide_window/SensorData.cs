using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SensorData
    {
        public string id { get; set; }
        public string aAX { get; set; }
        public string aAY { get; set; }
        public string aAZ { get; set; }
        public string aWX { get; set; }
        public string aWY { get; set; }
        public string aWZ { get; set; }
        //public string ahx { get; set; }
        //public string ahy { get; set; }
        //public string ahz { get; set; }

        public string bAX { get; set; }
        public string bAY { get; set; }
        public string bAZ { get; set; }
        public string bWX { get; set; }
        public string bWY { get; set; }
        public string bWZ { get; set; }
        //public string bhx { get; set; }
        //public string bhy { get; set; }
        //public string bhz { get; set; }

        public string cAX { get; set; }
        public string cAY { get; set; }
        public string cAZ { get; set; }
        public string cWX { get; set; }
        public string cWY { get; set; }
        public string cWZ { get; set; }
        //public string chx { get; set; }
        //public string chy { get; set; }
        //public string chz { get; set; }

        public string dAX { get; set; }
        public string dAY { get; set; }
        public string dAZ { get; set; }
        public string dWX { get; set; }
        public string dWY { get; set; }
        public string dWZ { get; set; }
        //public string dhx { get; set; }
        //public string dhy { get; set; }
        //public string dhz { get; set; }

        public string eAX { get; set; }
        public string eAY { get; set; }
        public string eAZ { get; set; }
        public string eWX { get; set; }
        public string eWY { get; set; }
        public string eWZ { get; set; }
        //public string ehx { get; set; }
        //public string ehy { get; set; }
        //public string ehz { get; set; }

        public string fAX { get; set; }
        public string fAY { get; set; }
        public string fAZ { get; set; }
        public string fWX { get; set; }
        public string fWY { get; set; }
        public string fWZ { get; set; }
        //public string fhx { get; set; }
        //public string fhy { get; set; }
        //public string fhz { get; set; }

        public string gAX { get; set; }
        public string gAY { get; set; }
        public string gAZ { get; set; }
        public string gWX { get; set; }
        public string gWY { get; set; }
        public string gWZ { get; set; }
        //public string ghx { get; set; }
        //public string ghy { get; set; }
        //public string ghz { get; set; }

        public string ACC { get; set; }

        public override string ToString()
        {
            return id + "," + aAX + "," + aAY + "," + aAZ+","+"acc:"+ACC;
        }

        public void setACC()
        {
           this.ACC = Convert.ToString(Math.Sqrt((double.Parse(this.bAX) * double.Parse(this.bAX))
                + (double.Parse(this.bAY) * double.Parse(this.bAY))
                + (double.Parse(this.bAZ) * double.Parse(this.bAZ))));
        }

        public List<double> getSensorDataList()
        {
            List<double> df = new List<double>();

            df.Add(Convert.ToDouble(this.aAX == "" ? "0" : this.aAX));
            df.Add(Convert.ToDouble(this.aAY == "" ? "0" : this.aAY));
            df.Add(Convert.ToDouble(this.aAZ == "" ? "0" : this.aAZ));
            df.Add(Convert.ToDouble(this.aWX == "" ? "0" : this.aWX));
            df.Add(Convert.ToDouble(this.aWY == "" ? "0" : this.aWY));
            df.Add(Convert.ToDouble(this.aWZ == "" ? "0" : this.aWZ));

            df.Add(Convert.ToDouble(this.bAX == "" ? "0" : this.bAX));
            df.Add(Convert.ToDouble(this.bAY == "" ? "0" : this.bAY));
            df.Add(Convert.ToDouble(this.bAZ == "" ? "0" : this.bAZ));
            df.Add(Convert.ToDouble(this.bWX == "" ? "0" : this.bWX));
            df.Add(Convert.ToDouble(this.bWY == "" ? "0" : this.bWY));
            df.Add(Convert.ToDouble(this.bWZ == "" ? "0" : this.bWZ));

            df.Add(Convert.ToDouble(this.cAX == "" ? "0" : this.cAX));
            df.Add(Convert.ToDouble(this.cAY == "" ? "0" : this.cAY));
            df.Add(Convert.ToDouble(this.cAZ == "" ? "0" : this.cAZ));
            df.Add(Convert.ToDouble(this.cWX == "" ? "0" : this.cWX));
            df.Add(Convert.ToDouble(this.cWY == "" ? "0" : this.cWY));
            df.Add(Convert.ToDouble(this.cWZ == "" ? "0" : this.cWZ));

            df.Add(Convert.ToDouble(this.dAX == "" ? "0" : this.dAX));
            df.Add(Convert.ToDouble(this.dAY == "" ? "0" : this.dAY));
            df.Add(Convert.ToDouble(this.dAZ == "" ? "0" : this.dAZ));
            df.Add(Convert.ToDouble(this.dWX == "" ? "0" : this.dWX));
            df.Add(Convert.ToDouble(this.dWY == "" ? "0" : this.dWY));
            df.Add(Convert.ToDouble(this.dWZ == "" ? "0" : this.dWZ));

            df.Add(Convert.ToDouble(this.eAX == "" ? "0" : this.eAX));
            df.Add(Convert.ToDouble(this.eAY == "" ? "0" : this.eAY));
            df.Add(Convert.ToDouble(this.eAZ == "" ? "0" : this.eAZ));
            df.Add(Convert.ToDouble(this.eWX == "" ? "0" : this.eWX));
            df.Add(Convert.ToDouble(this.eWY == "" ? "0" : this.eWY));
            df.Add(Convert.ToDouble(this.eWZ == "" ? "0" : this.eWZ));

            df.Add(Convert.ToDouble(this.fAX == "" ? "0" : this.fAX));
            df.Add(Convert.ToDouble(this.fAY == "" ? "0" : this.fAY));
            df.Add(Convert.ToDouble(this.fAZ == "" ? "0" : this.fAZ));
            df.Add(Convert.ToDouble(this.fWX == "" ? "0" : this.fWX));
            df.Add(Convert.ToDouble(this.fWY == "" ? "0" : this.fWY));
            df.Add(Convert.ToDouble(this.fWZ == "" ? "0" : this.fWZ));

            df.Add(Convert.ToDouble(this.gAX == "" ? "0" : this.gAX));
            df.Add(Convert.ToDouble(this.gAY == "" ? "0" : this.gAY));
            df.Add(Convert.ToDouble(this.gAZ == "" ? "0" : this.gAZ));
            df.Add(Convert.ToDouble(this.gWX == "" ? "0" : this.gWX));
            df.Add(Convert.ToDouble(this.gWY == "" ? "0" : this.gWY));
            df.Add(Convert.ToDouble(this.gWZ == "" ? "0" : this.gWZ));

            if (this.ACC == "") 
            {
                this.setACC();
            }
            df.Add(Convert.ToDouble(this.ACC));
                        
            return df;
        }

    }
}
