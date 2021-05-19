using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Match_Method
{
    public partial class pickGrafForm : Form
    {
        List<Answers> answers = new List<Answers>();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="an">Массив данных с ответами</param>
        /// <param name="opiration">Операция которая происходила</param>
        public pickGrafForm(List<Answers> an,string opiration)
        {
            InitializeComponent();
            answers = an;

            Graf.Series[0].Points.Clear();
            for(int i=0;i<answers.Count;i++)
            {
                Graf.Series[0].Points.AddXY(i, answers[i].values);
            }
            Graf.Series[0].LegendText = opiration;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
