using CPUFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = DataMaintenance.GetRecipeDashboard();
            SetCountText(dt, "Recipe", lblRecipesCount);
            SetCountText(dt, "Meal", lblMealsCount);
            SetCountText(dt, "Cookbook", lblCookbooksCount);
        }

        private void SetCountText(DataTable dt, string recordtype, Label lbl)
        {
            var rows = dt.Select($"DashboardType = '{recordtype}'");
            if (rows.Length > 0)
            {
                lbl.Text = rows[0]["DashboardCount"].ToString();
            }
        }
    }
}
