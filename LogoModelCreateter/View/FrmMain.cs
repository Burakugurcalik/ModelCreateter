using System.Windows.Forms;

namespace LogoModelCreateter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            rtViewValue.Text = "";
            int line = rtSendValue.Lines.Count();
            for (int i = 0; i < line; i++)
            {
                rtViewValue.Text += Environment.NewLine + "	   \"  " + rtSendValue.Lines[i].ToString().Replace("           ", "") + " \"+";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            rtViewValue.Text = "";
            int line = rtSendValue.Lines.Count();
            for (int i = 0; i < line; i++)
            {

                String Line = rtSendValue.Lines[i].ToString();

                String newline = "";
                if (Line.IndexOf("CREATE TABLE") >= 0)
                {
                    newline = "public class " + Line.ToString().Replace("[dbo].", "").Replace("(", "{").Replace("'", "").Replace("CREATE TABLE", "").Replace("`", "").Replace("Ecommerce", "Wordpress").Replace("burakko", "Wordpress").Replace("oc", "Opencart").Replace("[", "").Replace("]", "").Replace("[dbo].", "");
                }
                else if (Line.IndexOf(") ") >= 0 && Line.Length <= 5)
                {
                    newline = "}";
                }
                else
                {
                    String[] PArtlineee = Line.Split(' ');
                    if (Line.IndexOf("bigint") >= 0)
                    {

                        newline = "public long " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=0;";

                    }
                    if (Line.IndexOf("varchar") >= 0)
                    {

                        newline = "public string " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=" + "\"\";";

                    }
                    if (Line.IndexOf("int") >= 0)
                    {

                        newline = "public int " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=0;";

                    }
                    if (Line.IndexOf("longtext") >= 0)
                    {

                        newline = "public string " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=" + "\"\";";

                    }
                    if (Line.IndexOf("datetime") >= 0)
                    {

                        newline = "public string " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=" + "\"NULL\";";

                    }
                    if (Line.IndexOf("text") >= 0)
                    {

                        newline = "public string " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=" + "\"\";";

                    }
                    if (Line.IndexOf("tinyint") >= 0)
                    {

                        newline = "public int " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=0;";
                    }
                    if (Line.IndexOf("mediumtext") >= 0)
                    {

                        newline = "public string " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=" + "\"\";";

                    }
                    if (Line.IndexOf("float") >= 0)
                    {

                        newline = "public double " + PArtlineee[0].Replace("'", "").Replace("`", "").Replace("\t", "").Replace("[", "").Replace("]", "").Replace("[dbo].", "") + " { get; set; }=0;";

                    }

                }

                rtViewValue.Text += Environment.NewLine + newline;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            rtViewValue.Text = "";
            int line = rtSendValue.Lines.Count();
            String newline = "";
            String header = "";
            String SubColums = "";
            String ValuesSubColums = "";
            String InsertSubColums = "";
            for (int i = 0; i < line; i++)
            {

                String Line = rtSendValue.Lines[i].ToString();


                if (Line.IndexOf("public class") >= 0)
                {
                    newline = "INSERT INTO" + Line.ToString().Replace("public class", "");
                    header = Line.ToString().Replace("public class", "");
                }
                else if (Line.Length <= 5)
                {
                    if (Line.IndexOf("}") >= 0)
                    {
                        rtViewValue.Text += Environment.NewLine + "String Query = \"\";";
                        rtViewValue.Text += Environment.NewLine + "#region " + header + "_INSERT";
                        rtViewValue.Text += Environment.NewLine + "public String " + header + "_Insert(" + header + " Model) {";
                        rtViewValue.Text += Environment.NewLine + "Query=\"" + newline + "(" + SubColums.Substring(1) + ") VALUES (" + ValuesSubColums.Substring(1) + ")\";";
                        rtViewValue.Text += Environment.NewLine + "return Query;";
                        rtViewValue.Text += Environment.NewLine + "}";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        SubColums = "";
                        ValuesSubColums = "";
                    }

                }
                else
                {
                    int indexof = Line.IndexOf("public");
                    String[] PArtlineee = Line.Substring(indexof).Split(' ');

                    if (Line.IndexOf("public int Id") >= 0)
                    {

                    }

                    else if (Line.IndexOf("public string CreatedDate") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "");
                        ValuesSubColums += ", \"+\"getdate()";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }
                    else if (Line.IndexOf("public string ") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "");
                        ValuesSubColums += ", \"+\"'\"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"'";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }
                    else if (Line.IndexOf("public int") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "");
                        ValuesSubColums += ", \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }
                    else if (Line.IndexOf("public double") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "");
                        ValuesSubColums += ", \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "Recplace(\",\",\".\")" + "+\"";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }
                    else if (Line.IndexOf("public DateTime") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "");
                        ValuesSubColums += ", \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }


                }


            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            rtViewValue.Text = "";
            int line = rtSendValue.Lines.Count();
            String newline = "";
            String header = "";
            String SubColums = "";
            String ValuesSubColums = "";
            String InsertSubColums = "";
            for (int i = 0; i < line; i++)
            {

                String Line = rtSendValue.Lines[i].ToString();


                if (Line.IndexOf("public class") >= 0)
                {
                    newline = "UPDATE " + Line.ToString().Replace("public class", "") + " SET ";
                    header = Line.ToString().Replace("public class", "");
                }
                else if (Line.Length <= 5)
                {
                    if (Line.IndexOf("}") >= 0)
                    {

                        rtViewValue.Text += Environment.NewLine + "#region " + header + "_UPDATE";
                        rtViewValue.Text += Environment.NewLine + "public String " + header + "_Update(" + header + " Model) {";
                        rtViewValue.Text += Environment.NewLine + "Query=\"" + newline + SubColums.Substring(1) + " Where LOGICALREF=\"+Model.LOGICALREF;";
                        rtViewValue.Text += Environment.NewLine + "return Query;";
                        rtViewValue.Text += Environment.NewLine + "}";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        SubColums = "";
                        ValuesSubColums = "";
                    }

                }
                else
                {
                    int indexof = Line.IndexOf("public");
                    String[] PArtlineee = Line.Substring(indexof).Split(' ');

                    if (Line.IndexOf("public int LOGICALREF") >= 0)
                    {

                    }

                    else if (Line.IndexOf("public string CreatedDate") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "") + "=";
                        ValuesSubColums += ", \"+\"getdate()";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }
                    else if (Line.IndexOf("public string ") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "") + "=" + " \"+\"'\"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"'"; ;

                    }
                    else if (Line.IndexOf("public int") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "") + "=" + " \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"";
                    }
                    else if (Line.IndexOf("public double") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "") + "=" + " \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + ".Replace(\",\", \".\")" + " +\"";
                    }
                    else if (Line.IndexOf("public DateTime") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "");
                        ValuesSubColums += ", \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }


                }


            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            rtViewValue.Text = "";
            int line = rtSendValue.Lines.Count();
            String newline = "";
            String header = "";
            String SubColums = "";
            String ValuesSubColums = "";
            String InsertSubColums = "";

            rtViewValue.Text += Environment.NewLine + "#region SELECT ALL";
            for (int i = 0; i < line; i++)
            {

                String Line = rtSendValue.Lines[i].ToString();



                if (Line.IndexOf("public class") >= 0)
                {
                    newline = "UPDATE " + Line.ToString().Replace("public class", "") + " SET ";
                    header = Line.ToString().Replace("public class", "");
                }
                else if (Line.Length <= 5)
                {
                    if (Line.IndexOf("}") >= 0)
                    {

                        rtViewValue.Text += Environment.NewLine + "#region " + header + "_SELECTALL";
                        rtViewValue.Text += Environment.NewLine + "public String " + header + "_Select_ALL(" + header + " Model) {";
                        rtViewValue.Text += Environment.NewLine + "Query=\"" + "SELECT * FROM  " + header + "  Order By Id Desc\";";
                        rtViewValue.Text += Environment.NewLine + "return Query;";
                        rtViewValue.Text += Environment.NewLine + "}";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        SubColums = "";
                        ValuesSubColums = "";
                    }

                }
                else
                {
                    int indexof = Line.IndexOf("public");
                    String[] PArtlineee = Line.Substring(indexof).Split(' ');

                    if (Line.IndexOf("Id") >= 0)
                    {
                        SubColums += "  " + PArtlineee[2].Replace("'", "").Replace("`", "") + "=" + " \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "";

                        rtViewValue.Text += Environment.NewLine + "#region " + header + "_SELECT_" + PArtlineee[2].Replace("'", "").Replace("`", "");
                        rtViewValue.Text += Environment.NewLine + "public String " + header + "_Select_" + PArtlineee[2].Replace("'", "").Replace("`", "") + "(" + header + " Model) {";
                        rtViewValue.Text += Environment.NewLine + "Query=\"" + " SELECT * FROM " + header + " WHERE" + SubColums + ";";

                        rtViewValue.Text += Environment.NewLine + "return Query;";
                        rtViewValue.Text += Environment.NewLine + "}";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        SubColums = "";
                        ValuesSubColums = "";
                    }

                    else if (Line.IndexOf("public string CreatedDate") >= 0)
                    {

                        SubColums += " CreatedDate between Convert(datetime,'\"+Model.CreatedDate+\"',104) and Convert(datetime,'\"+Model.EndDate+\"',104)\" ";



                        rtViewValue.Text += Environment.NewLine + "#region " + header + "_SELECT_" + PArtlineee[2].Replace("'", "").Replace("`", "");
                        rtViewValue.Text += Environment.NewLine + "public String " + header + "_Select_" + PArtlineee[2].Replace("'", "").Replace("`", "") + "(" + header + " Model) {";
                        rtViewValue.Text += Environment.NewLine + "Query=\"" + " SELECT * FROM " + header + " WHERE" + SubColums + ";";

                        rtViewValue.Text += Environment.NewLine + "return Query;";
                        rtViewValue.Text += Environment.NewLine + "}";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        SubColums = "";
                        ValuesSubColums = "";
                    }
                    else if (Line.IndexOf("public string EndDate") >= 0)
                    {
                    }
                    else if (Line.IndexOf("public string ") >= 0)
                    {

                        SubColums += " " + PArtlineee[2].Replace("'", "").Replace("`", "") + " LIKE " + " \"+\"'%\"+" + "" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "" + "+\"%'\""; ;


                        rtViewValue.Text += Environment.NewLine + "#region " + header + "_SELECT_" + PArtlineee[2].Replace("'", "").Replace("`", "");
                        rtViewValue.Text += Environment.NewLine + "public String " + header + "_Select_" + PArtlineee[2].Replace("'", "").Replace("`", "") + "(" + header + " Model) {";
                        rtViewValue.Text += Environment.NewLine + "Query=\"" + " SELECT * FROM " + header + " WHERE" + SubColums + ";";

                        rtViewValue.Text += Environment.NewLine + "return Query;";
                        rtViewValue.Text += Environment.NewLine + "}";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        SubColums = "";
                        ValuesSubColums = "";
                    }
                    else if (Line.IndexOf("public int") >= 0)
                    {


                        SubColums += " " + PArtlineee[2].Replace("'", "").Replace("`", "") + "=" + " \"+\"'\"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"'\""; ;


                        rtViewValue.Text += Environment.NewLine + "#region " + header + "_SELECT_" + PArtlineee[2].Replace("'", "").Replace("`", "");
                        rtViewValue.Text += Environment.NewLine + "public String " + header + "_Select_" + PArtlineee[2].Replace("'", "").Replace("`", "") + "(" + header + " Model) {";
                        rtViewValue.Text += Environment.NewLine + "Query=\"" + " SELECT * FROM " + header + " WHERE" + SubColums + ";";

                        rtViewValue.Text += Environment.NewLine + "return Query;";
                        rtViewValue.Text += Environment.NewLine + "}";
                        rtViewValue.Text += Environment.NewLine + "#endregion ";
                        SubColums = "";
                        ValuesSubColums = "";
                    }

                    else if (Line.IndexOf("public DateTime") >= 0)
                    {

                        SubColums += ", " + PArtlineee[2].Replace("'", "").Replace("`", "");
                        ValuesSubColums += ", \"+" + "Model." + PArtlineee[2].Replace("'", "").Replace("`", "") + "+\"";
                        InsertSubColums += ", " + PArtlineee[1].Replace("'", "").Replace("`", "") + " " + PArtlineee[2].Replace("'", "").Replace("`", "");
                    }


                }


            }
        }

        private void Btn6_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            rtViewValue.Text = "";
            int line = rtSendValue.Lines.Count();
            rtViewValue.Text = "";
            for (int i = 0; i < line; i++)
            {
                rtViewValue.Text += Environment.NewLine + " SqlQuerys." + rtSendValue.Lines[i].ToString() + "SqlQuerys " + rtSendValue.Lines[i].ToString() + "SqlQuerys = new SqlQuerys." + rtSendValue.Lines[i].ToString() + "SqlQuerys();";

            }
            for (int i = 0; i < line; i++)
            {
                rtViewValue.Text += Environment.NewLine + "  #region " + rtSendValue.Lines[i].ToString() + "_INSERT";
                rtViewValue.Text += Environment.NewLine + "  public Boolean " + rtSendValue.Lines[i].ToString() + "_Insert(" + rtSendValue.Lines[i].ToString() + " Model)";
                rtViewValue.Text += Environment.NewLine + "{";
                rtViewValue.Text += Environment.NewLine + "try";
                rtViewValue.Text += Environment.NewLine + "{";
                rtViewValue.Text += Environment.NewLine + "if (Model.Id>0)";
                rtViewValue.Text += Environment.NewLine + "{";
                rtViewValue.Text += Environment.NewLine + "sqlmethods.ExecuteCmd(" + rtSendValue.Lines[i].ToString() + "SqlQuerys." + rtSendValue.Lines[i].ToString() + "_Update(Model));";

                rtViewValue.Text += Environment.NewLine + "}";
                rtViewValue.Text += Environment.NewLine + "else";
                rtViewValue.Text += Environment.NewLine + "{";
                rtViewValue.Text += Environment.NewLine + "sqlmethods.ExecuteCmd(" + rtSendValue.Lines[i].ToString() + "SqlQuerys." + rtSendValue.Lines[i].ToString() + "_Insert(Model));";

                rtViewValue.Text += Environment.NewLine + "}";
                rtViewValue.Text += Environment.NewLine + "return true;";
                rtViewValue.Text += Environment.NewLine + "}";
                rtViewValue.Text += Environment.NewLine + " catch (Exception ex)";
                rtViewValue.Text += Environment.NewLine + "{";
                rtViewValue.Text += Environment.NewLine + "return false;";
                rtViewValue.Text += Environment.NewLine + "}";
                rtViewValue.Text += Environment.NewLine + "}";
                rtViewValue.Text += Environment.NewLine + "#endregion";
            }
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            rtViewValue.Text = "";
            rtViewValue.Text = "";
        }
    }
}