using System;
using System.Globalization;
using System.Windows.Forms;

namespace Consultorio.Formularios
{
    public partial class FrmCalendario : Form
    {
        int month, year;

        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            mostrarDías();
        }

        private void mostrarDías()
        {
            dayContainer.Controls.Clear();

            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelDato.Text = mesNombre + " " + year;

            DateTime start = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = (int)start.DayOfWeek;

            // Añadir espacios en blanco antes del primer día
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            // Añadir días del mes
            for (int i = 1; i <= days; i++)
            {
                UserControlDia ucdays = new UserControlDia();
                ucdays.dia(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            mostrarDías();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            mostrarDías();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
