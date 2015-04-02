using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace _
{
    public partial class FormMain :CCWin.CCSkinMain
    {
        public FormMain()
        {
            InitializeComponent();
        }
        IPEndPoint host =new IPEndPoint(IPAddress.Parse("127.0.0.1"), 213);
        UdpClient udpsender=new UdpClient();
        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            string value = "";
            #region
            char c = e.KeyChar;
            int i = (int)c;
            
            switch(c)
            {
                case '`': value = "#"; break;
                case '1': value = c.ToString(); break;
                case '2': value = c.ToString(); break;
                case '3': value = c.ToString(); break;
                case '4': value = c.ToString(); break;
                case '5': value = c.ToString(); break;
                case '6': value = c.ToString(); break;
                case '7': value = c.ToString(); break;
                case '8': value = c.ToString(); break;
                case '9': value = c.ToString(); break;
                case '#': value = c.ToString(); break;
                case '0': value = c.ToString(); break;                    
                case '-': value = c.ToString(); break;
                case '=': value = "±"; break;

                case 'q': value = "「」"; break;
                case 'w': value = "^"; break;
                case 'e': value = "⊙"; break;
                case 'r': value = "Ⓡ"; break;
                case 't': value = c.ToString(); break;
                case 'y': value = "∞"; break;
                case 'u': value = "×"; break;
                case 'i': value = c.ToString(); break;
                case 'o': value = "∈"; break;
                case 'p': value = "✞"; break;
                case '[': value = "{}"; break;
                case ']': value = "[]"; break;
                case '\\': value = "、"; break;

                case 'a': value = "="; break;
                case 's': value = c.ToString(); break;
                case 'd': value = "∠"; break;
                case 'f': value = "π"; break;
                case 'g': value = "()"; break;
                case 'h': value = "㏒"; break;
                case 'j': value = "<>"; break;
                case 'k': value = "?"; break;
                case 'l': value = "∨"; break;
                case ';': value = "∧"; break;
                case '\'': value = "┐"; break;
        
                case 'z': value ="☑"; break;
                case 'x': value ="☒"; break;
                case 'c':value ="Ⓒ"; break;
                case 'v': value ="❣"; break;
                case 'b': value ="≠"; break;
                case 'n': value ="≡"; break;
                case 'm': value ="÷"; break;
                case ',': value = c.ToString(); break;
                case '.': value = c.ToString(); break;
                case '/': value ="◐◑"; break;

                case ' ':value ="☾☽"; break;           
            }
            
            if(i==27)value = "♟";               
            
            #endregion
            byte[] data=System.Text.Encoding.UTF8.GetBytes(value);   
            udpsender.Send(data, data.Length, host); 
        }
    }
}
