using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using S7.Net;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace proiectPLC
{
    
    public partial class FormPLC : Form
    {
        public Timer timer1;
        public Timer timer2;
        public Timer timer3;
        public Plc plc = null;
        public  object current;
        public  object previous="Default";
        public int nrlafel;
       



        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
       

        void textBoxLastValue_GotFocus(object sender, EventArgs e)
        {
            HideCaret(textBoxLastValue.Handle);
        }

        public FormPLC()
        {
            InitializeComponent();
        }

        private void buttonDeconectarePLC_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Close();
                if (!plc.IsConnected)
                {
                    MessageBox.Show("PLC deconectat");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PLC nu a fost deconectat");
            }
            
           
        }

        public void ConectarePLC()
        {
            try
            {
                string Rack = "0";
                string Slot = "0";
                string Ip = "10.21.7.217";


                CpuType cpu = (CpuType)Enum.Parse((typeof(CpuType)), "S71200");

                plc = new Plc(cpu, Ip, Convert.ToInt16(Rack), Convert.ToInt16(Slot));



                plc.Open();
            }
             catch (Exception)
            {

            }
                

                //if (plc.IsConnected)
                //{
                //    MessageBox.Show("PLC conectat");
                //}
           

        }

        private void buttonConectarePLC_Click(object sender, EventArgs e)
        {

            ConectarePLC();
            
        }

        /*



Database databaseObject = new Database();
databaseObject.OpenConnection();

string query = "SELECT * from PLCRecords WHERE Id="+2;
SqlCommand mycommand = new SqlCommand(query,databaseObject.myConnection);
string rez = "";
SqlDataReader re = mycommand.ExecuteReader();
if (re.HasRows)
{

    while (re.Read())
    {
        rez = re[2].ToString();

    }
}
re.Close();
     MessageBox.Show(rez);
    databaseObject.CloseConnection();

*/

        private void FormPLC_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "";
            textBoxLastValue.GotFocus += new EventHandler(textBoxLastValue_GotFocus);
            ConectarePLC();
            InitTimer3();
            InitTimer1();
            InitTimer2();
           
         
        }

        public void InitTimer1()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500; // nr sec in mili
            timer1.Start();

           


        }

        public void InitTimer2()
        {
            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1000; // nr sec in mili
            timer2.Start();
        }

        public void InitTimer3()
        {
            timer3 = new Timer();
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = 200; // nr sec in mili
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readPLC();
            RewriteValue();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DisplayPLC();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            checkConnection();
        }

        public void checkConnection()
        {
            if (plc.IsConnected)
            {
                labelStatus.Text = "PLC CONNECTED";
            }
            else
            {
                labelStatus.Text = "PLC NOT CONNECTED. RECONNECTING...";
                ConectarePLC();
            }
        }

        public void readPLC()
        {
            try
            {
                current = plc.Read(DataType.DataBlock, 10, 77, VarType.String, 17);
            }
            catch (Exception)
            {

            }

              

              
           
            
               
           
               
                

        }

        public void RewriteValue()
        {
            
                if (current.ToString().Contains("8") == true)
                {
                
                if (previous.ToString() == current.ToString())
                {
                    nrlafel++;
                }
                else
                {
                    nrlafel = 0;
                }


                previous = current;

             
                }
            
            

           
      
            
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void DisplayPLC()
        {
            try
            {
                textBoxLastValue.Text = previous.ToString();

                if (previous.ToString().Contains("8") == true)
                {

                    Database databaseObject = new Database();
                    databaseObject.OpenConnection();
                    string temporary = "Default";

                    string rev = Reverse(previous.ToString());
                    string gog = rev.Remove(0, 6);
                    string fin = Reverse(gog);
                    string replacement = fin.Trim('\r', '\n');

                    // string[] lines = previous.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    // string address = lines[0];  // or safe: lines.ElementAtOrDefault(3)  


                    string query = "SELECT KitName from PLCRecords WHERE SeatCodeRear='" + replacement + "'";
                    SqlCommand myCommand = new SqlCommand(query, databaseObject.myConnection);
                    //  myCommand.Parameters.AddWithValue("@SeatCodeRear",previous.ToString());




                    //  MessageBox.Show(address);



                    //  System.IO.File.WriteAllText(@"C:\test\path.txt", replacement);


                    temporary = (string)myCommand.ExecuteScalar().ToString();
                    //string rez = "";
                    //SqlDataReader re = myCommand.ExecuteReader();
                    //if (re.HasRows)
                    //{

                    //    while (re.Read())
                    //    {
                    //        rez = re[1].ToString();

                    //    }
                    //}
                    //re.Close();

                    databaseObject.CloseConnection();

                    textBoxDescription.Text = temporary;

                    // MessageBox.Show(temporary);

                    if (nrlafel >= 3600)
                    {

                        labelError.Visible = true;
                    }
                    else
                    {
                        labelError.Visible = false;
                    }




                }
            }
            catch (Exception)
            {

            }
        




        }
     
   
       
        private void buttonCitireAdresa_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
