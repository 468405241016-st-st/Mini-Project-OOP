using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_OOP.Forms
{
    public partial class ucBooking : Form
    {
        private readonly DatabaseService _dbService;
        private readonly IRepository<tbl_Bookings> _booking;
        public ucBooking()
        {
            InitializeComponent();

            string dbPath = Application.StartupPath + @"\Mini_Project_Database.accdb";
            _dbService = new DatabaseService(dbPath);

            _booking = new Repository<tbl_Bookings> (_dbService);

        }
    }
}
