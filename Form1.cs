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
using System.Configuration;

namespace BD_P1
{
    public partial class MoviesForm : Form
    {
        private SqlConnection connection;
        private bool tableRefilling = false;
        private int addingNewRow = 0;

        public MoviesForm()
        {
            InitializeComponent();
            EstablishConnection();
            dateTimePickerReleaseDateTo.Value = DateTime.Now;
        }

        public void EstablishConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BDP1"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                IDbCommand com = createFilterCommand();

                using (IDataReader reader = com.ExecuteReader())
                {
                    tableRefilling = true;
                    dataTable.Rows.Clear();
                    while (reader.Read())
                    {
                        dataTable.Rows.Add($"{reader["Id"]}", $"{reader["Title"]}", $"{reader["ReleaseDate"]}", $"{reader["Budget"]}", $"{ reader["AvgRating"]}",
                            $"{reader["Imax3D"]}", $"{reader["TicketsSold"]}");
                    }
                    tableRefilling = false;
                }
            }
        }

        private IDbCommand createFilterCommand()
        {
            string comText = $"SELECT * FROM Movies WHERE Imax3D=@imax3d " +
                $"AND ReleaseDate>=@releasedatefrom AND ReleaseDate<=@releasedateto";
            List<SqlParameter> sqlParams = new List<SqlParameter>();

            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@imax3d",
                Value = $"{checkBox3DImax.Checked}",
                SqlDbType = SqlDbType.Bit
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@releasedatefrom",
                Value = $"{dateTimePickerReleaseDateFrom.Value.Date}",
                SqlDbType = SqlDbType.Date
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@releasedateto",
                Value = $"{dateTimePickerReleaseDateTo.Value.Date}",
                SqlDbType = SqlDbType.Date
            });

            if (textBoxTitle.Text != "")
            {
                comText += $" AND Title LIKE @title";
                sqlParams.Add(new SqlParameter()
                {
                    ParameterName = "@title",
                    Value = $"%{textBoxTitle.Text}%",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                });
            }
            if (textBoxBudgetMin.Text != "")
            {
                comText += $" AND Budget>=@minbudget";
                sqlParams.Add(new SqlParameter()
                {
                    ParameterName = "@minbudget",
                    Value = $"{textBoxBudgetMin.Text}",
                    SqlDbType = SqlDbType.Money
                });
            }
            if (textBoxBudgetMax.Text != "")
            {
                comText += $" AND Budget<=@maxbudget";
                sqlParams.Add(new SqlParameter()
                {
                    ParameterName = "@maxbudget",
                    Value = $"{textBoxBudgetMax.Text}",
                    SqlDbType = SqlDbType.Money
                });
            }
            if (textBoxRatingMin.Text != "")
            {
                comText += $" AND AvgRating>=@minrating";
                sqlParams.Add(new SqlParameter()
                {
                    ParameterName = "@minrating",
                    Value = $"{textBoxRatingMin.Text}",
                    SqlDbType = SqlDbType.Decimal,
                });
            }
            if (textBoxRatingMax.Text != "")
            {
                comText += $" AND AvgRating<=@maxrating";
                sqlParams.Add(new SqlParameter()
                {
                    ParameterName = "@maxrating",
                    Value = $"{textBoxRatingMax.Text}",
                    SqlDbType = SqlDbType.Decimal
                });
            }
            comText += ";";

            IDbCommand com = new SqlCommand(comText, connection);
            foreach (var prm in sqlParams)
                com.Parameters.Add(prm);
            return com;
        }

        private void MoviesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                List<int> ids = new List<int>();

                foreach (DataGridViewRow row in dataTable.SelectedRows)
                    ids.Add(int.Parse((string)row.Cells["ColId"].Value));

                if (ids.Any())
                    createDeleteCommand(ids).ExecuteNonQuery();
            }
        }

        private IDbCommand createDeleteCommand(List<int> ids)
        {
            string comText = "DELETE FROM Movies WHERE Id IN (";
            List<SqlParameter> sqlParams = new List<SqlParameter>();

            int i = 0;
            foreach (int id in ids)
            {
                comText += $"@id{i}, ";
                sqlParams.Add(new SqlParameter()
                {
                    ParameterName = $"@id{i}",
                    Value = $"{id}",
                    SqlDbType = SqlDbType.Int
                });
                i++;
            }

            comText = comText.Trim().Trim(',');
            comText += ");";

            IDbCommand com = new SqlCommand(comText, connection);
            foreach (var prm in sqlParams)
                com.Parameters.Add(prm);
            return com;
        }

        private void dataTable_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!tableRefilling)
                switch (addingNewRow)
                {
                    case 0:
                        try { createModifyCommand(dataTable.Rows[e.RowIndex]).ExecuteNonQuery(); }
                        catch (FormatException) { }
                        break;

                    case 1:
                        addingNewRow = 2;
                        dataTable.Rows[e.RowIndex].Cells["ColId"].Value = createInsertCommand(dataTable.Rows[e.RowIndex]).ExecuteScalar();
                        labelTitle.Text = $"{dataTable.Rows[e.RowIndex].Cells["ColId"].Value}";
                        break;

                    case 2:
                        addingNewRow = 0;
                        break;
                }
        }

        private IDbCommand createModifyCommand(DataGridViewRow row)
        {
            string comText = "UPDATE Movies " +
                "SET Title=@title, ReleaseDate=@releasedate, Budget=@budget, AvgRating=@rating, Imax3D=@imax3d, TicketsSold=@ticketssold " +
                "WHERE Id=@id;";
            List<SqlParameter> sqlParams = new List<SqlParameter>();

            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@title",
                Value = $"{(string)row.Cells["ColTitle"].Value}",
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@releasedate",
                Value = $"{(string)row.Cells["ColReleaseDate"].Value}",
                SqlDbType = SqlDbType.Date
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@budget",
                Value = $"{(string)row.Cells["ColBudget"].Value}",
                SqlDbType = SqlDbType.Money
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@rating",
                Value = $"{row.Cells["ColAvgRating"].Value.ToString()}",
                SqlDbType = SqlDbType.Decimal
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@imax3d",
                Value = row.Cells["Col3DImax"].Value != null ? $"{row.Cells["Col3DImax"].Value.ToString()}" : bool.FalseString,
                SqlDbType = SqlDbType.Bit
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@ticketssold",
                Value = $"{(string)row.Cells["ColTicketsSold"].Value}",
                SqlDbType = SqlDbType.Int
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@id",
                Value = $"{row.Cells["ColId"].Value}",
                SqlDbType = SqlDbType.Int
            });

            IDbCommand com = new SqlCommand(comText, connection);
            foreach (var prm in sqlParams)
                com.Parameters.Add(prm);
            return com;
        }

        private void dataTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            addingNewRow = 1;
        }

        private IDbCommand createInsertCommand(DataGridViewRow row)
        {
            string comText = "INSERT INTO Movies (Title, ReleaseDate, Budget, AvgRating, Imax3D, TicketsSold) " +
                "VALUES(@title, @releasedate, @budget, @rating, @imax3d, @ticketssold); " +
                "SELECT SCOPE_IDENTITY();";
            List<SqlParameter> sqlParams = new List<SqlParameter>();

            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@title",
                Value = $"{(string)row.Cells["ColTitle"].Value}",
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@releasedate",
                Value = $"{(string)row.Cells["ColReleaseDate"].Value}",
                SqlDbType = SqlDbType.Date
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@budget",
                Value = $"{(string)row.Cells["ColBudget"].Value}",
                SqlDbType = SqlDbType.Money
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@rating",
                Value = $"{(string)row.Cells["ColAvgRating"].Value}",
                SqlDbType = SqlDbType.Decimal
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@imax3d",
                Value = row.Cells["Col3DImax"].Value != null ? $"{(bool)row.Cells["Col3DImax"].Value}" : false,
                SqlDbType = SqlDbType.Bit
            });
            sqlParams.Add(new SqlParameter()
            {
                ParameterName = "@ticketssold",
                Value = $"{(string)row.Cells["ColTicketsSold"].Value}",
                SqlDbType = SqlDbType.Int
            });

            IDbCommand com = new SqlCommand(comText, connection);
            foreach (var prm in sqlParams)
                com.Parameters.Add(prm);
            return com;
        }
    }
}
