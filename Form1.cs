using System.Collections.Generic;

namespace Mega645
{
    public partial class Form1 : Form
    {
        int roundWheel = 100000;
        int megaIndex = 0;
        int powerIndex = 0;

        public Form1()
        {
            InitializeComponent();
            randomMega645();
            randomPower655();
            randomMega645();
            randomPower655();
            randomMega645();
            randomPower655();
        }

        private void btnMega645_Click(object sender, EventArgs e)
        {
            randomMega645();
            randomMega645();
            randomMega645();
        }

        private void randomMega645()
        {
            Random r = new Random();

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < roundWheel; i++)
            {
                int rInt = r.Next(1, 45);
                Console.WriteLine(rInt);
                if (rInt > 0)
                {
                    if (keyValuePairs.ContainsKey(rInt))
                    {

                        int currentCount;
                        keyValuePairs.TryGetValue(rInt, out currentCount);
                        currentCount += 1;
                        keyValuePairs.Remove(rInt);
                        keyValuePairs.Add(rInt, currentCount);

                    }
                    else { keyValuePairs.Add(rInt, 1); }

                }
            }

            int lastMaxCount = roundWheel;
            int currentCount1;
            int currentTemp;
            int currentNumber = 0;

            string kq = "";
            SortedDictionary<int, int> reqsults = new SortedDictionary<int, int>();
            for (int id = 0; id < 6; id++)
            {
                currentCount1 = 0;
                currentNumber = 0;
                for (int i = 0; i < 45; i++)
                {
                    keyValuePairs.TryGetValue(i, out currentTemp);
                    if (currentTemp > currentCount1 && currentTemp < lastMaxCount)
                    {
                        currentNumber = i + 1;
                        currentCount1 = currentTemp;
                    }

                }

                lastMaxCount = currentCount1;
                //kq += currentNumber + " ";// + "(" + currentCount1 + "), ";
                reqsults.Add(currentNumber, currentCount1);
            }

            foreach (int num in reqsults.Keys)
            {
                kq += num + " ";
            }

            megaIndex++;
            if (megaIndex==1) {
                lblMega1.Text = kq;
            } else if (megaIndex==2)
            {
                lblMega2.Text = kq;
            } else
            {
                lblMega3.Text = kq;
                megaIndex = 0;
            }            
        }

        private void btnPower655_Click(object sender, EventArgs e)
        {
            randomPower655();
            randomPower655();
            randomPower655();
        }

        private void randomPower655()
        {
            Random r = new Random();

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < roundWheel; i++)
            {
                int rInt = r.Next(1, 55);
                Console.WriteLine(rInt);
                if (rInt > 0)
                {
                    if (keyValuePairs.ContainsKey(rInt))
                    {

                        int currentCount;
                        keyValuePairs.TryGetValue(rInt, out currentCount);
                        currentCount += 1;
                        keyValuePairs.Remove(rInt);
                        keyValuePairs.Add(rInt, currentCount);

                    }
                    else { keyValuePairs.Add(rInt, 1); }

                }
            }

            int lastMaxCount = roundWheel;
            int currentCount1;
            int currentTemp;
            int currentNumber = 0;

            string kq = "";
            SortedDictionary<int,int> reqsults = new SortedDictionary<int,int>();

            for (int id = 0; id < 6; id++)
            {
                currentCount1 = 0;
                currentNumber = 0;
                for (int i = 0; i < 55; i++)
                {
                    keyValuePairs.TryGetValue(i, out currentTemp);
                    if (currentTemp > currentCount1 && currentTemp < lastMaxCount)
                    {
                        currentNumber = i + 1;
                        currentCount1 = currentTemp;
                    }

                }

                reqsults.Add(currentNumber, currentCount1);

                lastMaxCount = currentCount1;
                //kq += currentNumber + " ";// + "(" + currentCount1 + "), ";
            }

            foreach(int num in reqsults.Keys)
            {
                kq += num + " ";
            }

            powerIndex++;
            if(powerIndex == 1) { 
                labelPower1.Text = kq;
            } else if(powerIndex == 2)
            {
                labelPower2.Text = kq;
            } else
            {
                labelPower3.Text = kq;
                powerIndex = 0;
            }
        }
    }
}
