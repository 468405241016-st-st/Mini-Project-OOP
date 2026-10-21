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
    public partial class ucDashboard : Form
    {
        private readonly DatabaseService _dbService;
        private readonly IRepository<tbl_Customers> _customerRepo;
        private readonly IRepository<tbl_Rooms> _roomRepo;
        public ucDashboard()
        {
            InitializeComponent();

            string dbPath = Application.StartupPath + @"\Mini_Project_Database.accdb";
            _dbService = new DatabaseService(dbPath);

            _customerRepo = new Repository<tbl_Customers>(_dbService);
            _roomRepo = new Repository<tbl_Rooms>(_dbService);
        }
    }
}
