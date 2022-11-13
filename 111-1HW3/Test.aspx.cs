using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
	public partial class Test : System.Web.UI.Page
	{
		String[] s_Category = new string[2] {"蔬菜", "水果"};
        String[,] s_Food = new string[2, 2] {{"A菜", "空心菜"}, {"番茄", "火龍果"}};

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				for (int i_ct = 0; i_ct < s_Category.Length; i_ct++)
				{
					ListItem L_i = new ListItem();
					L_i.Text = s_Category[i_ct];
					L_i.Value = s_Category[i_ct];

					ddl_Category.Items.Add(L_i);
                }
				mt_GenSecondList();
            }
		}

		protected void mt_GenSecondList()
		{
			int i_ind = ddl_Category.SelectedIndex;
			ddl_Food.Items.Clear();
            for (int i_ct = 0; i_ct < s_Food.GetLength(1); i_ct++)
            {
                ListItem L_i = new ListItem();
                L_i.Text = s_Food[i_ind, i_ct];
                L_i.Value = s_Food[i_ind, i_ct];

                ddl_Food.Items.Add(L_i);
            }
        }

		protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
		{
			mt_GenSecondList();

        }
	}
}