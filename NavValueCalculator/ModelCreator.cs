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

namespace NavValueCalculator
{
    public partial class ModelCreator : Form
    {
        public ModelCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String qty = richTextBox1.Text.Trim();
            DataTable dt = ReturnQueryResultDatatable(qty);


            String Modelname = txt_modelname.Text;
            String ModelMastername = Modelname+"Master";
            String Modelmasterlist = Modelname + "list";
            String Reponame = Modelname + "Repo";
            createModel(dt,Modelname, ModelMastername, Modelmasterlist);
            if (chK_PostIndex.Checked)
            {
                richTextBox3.Text = IndexCreatorPost(dt, Modelmasterlist);
            }
            else
            {
                richTextBox3.Text = IndexCreator(dt, Modelmasterlist);
            }
          
          rht_repo.Text=  RepoCreator(dt, Modelname, ModelMastername, Modelmasterlist,Reponame);
        }


        public void createModel(DataTable dt,String modelname, String ModelMastername, String Modelmasterlist)
        {
            String Prop = " public class "+ modelname + "{ " + Environment.NewLine;


            if(chk_isselected.Checked)
            {
                Prop = Prop + " public System.Boolean IsSelected { get; set; }" + Environment.NewLine;
            }
          

            foreach (DataColumn col in dt.Columns)
            {


                String datatype = col.DataType.ToString();

                 Prop = Prop+ "public  " + datatype + "  " + col.ColumnName + "  " + "{ get; set; }"+ Environment.NewLine;

            }
            Prop = Prop + "}" + Environment.NewLine + Environment.NewLine;


            String Prop1 =    "public class "+ ModelMastername + "{" + Environment.NewLine;
            Prop1 = Prop1 + " public int ID { get; set; }" + Environment.NewLine;
            Prop1 = Prop1 + " public int SubID { get; set; }" + Environment.NewLine;

            Prop1 = Prop1 + " public String AddedBy { get; set; }" + Environment.NewLine;
            Prop1 = Prop1 + " public DateTime AddedDate { get; set; }" + Environment.NewLine;
            Prop1 = Prop1+   "public List<"+ modelname + "> "+ Modelmasterlist + " { get; set; }"+ Environment.NewLine;
            Prop1 = Prop1 + "}" + Environment.NewLine;



            richTextBox2.Text = Prop + Environment.NewLine + Prop1 + Environment.NewLine;
           
        }



        public String RepoCreator(DataTable dt, String modelname, String ModelMastername, String Modelmasterlist, string Reponame)
        {
            String Prop3 = " public class " + Reponame + "{ " + Environment.NewLine;
             Prop3 = Prop3+ DataFetcher(dt, modelname);

            string Prop4 = masterdataFetch(ModelMastername, Modelmasterlist);


            return (Prop3 +Environment.NewLine + Prop4 + Environment.NewLine)+"}";
        }



        public String masterdataFetch(string ModelMastername, String Modelmasterlist)
        {


          String masterfetch= @"  public " + ModelMastername +  "  Get"+ ModelMastername + "Data(int id) { " + Environment.NewLine;


            masterfetch = masterfetch + ModelMastername  +" " + FirstCharToLower(ModelMastername)+" = new "+ ModelMastername + "();" + Environment.NewLine;
            masterfetch = masterfetch + @" DataTable dt = new DataTable(); "+ Environment.NewLine+ " SqlCommand cmd = new SqlCommand(); " + Environment.NewLine + " cmd.CommandText= 123; " + Environment.NewLine + "   cmd.Parameters.AddWithValue(, 0); " + Environment.NewLine + "  cmd.CommandType = CommandType.StoredProcedure;" + Environment.NewLine + " "+
               " cmd.CommandType = CommandType.StoredProcedure;" + Environment.NewLine + "dt = QueryFunctions.ReturnQueryResultDatatable(cmd); " + Environment.NewLine;


            masterfetch = masterfetch + FirstCharToLower(ModelMastername)+"."+ Modelmasterlist + " = Get" + Modelmasterlist + "(dt);" + Environment.NewLine;

            masterfetch = masterfetch +"   return " + FirstCharToLower(ModelMastername)+"; }";

            return masterfetch;

        }


        public String DataFetcher(DataTable dt, String modelname)
        { 
            String Prop = "  public List<" + modelname + "> Get" + modelname + "list(DataTable datatable) " + Environment.NewLine+ " { " + Environment.NewLine;

            Prop = Prop + "List < " + modelname + "> list = new List<" + modelname + ">();" + Environment.NewLine;

            Prop = Prop + "for (int i = 0; i < datatable.Rows.Count; i++)  " + Environment.NewLine+ " { " + Environment.NewLine;

            Prop = Prop  +modelname +"  "  +  FirstCharToLower( modelname) + " = new  "+modelname + "();" + Environment.NewLine;

            for (int j = 0; j < dt.Columns.Count; j++)
            {
                
                string colname = dt.Columns[j].ColumnName;

                if (dt.Columns[j].DataType.ToString()== "System.String")
                {
                    Prop = Prop + "" + FirstCharToLower(modelname) + "." + colname + "  = datatable.Rows[i][\"" + colname + "\"].ToString(); " + Environment.NewLine;
                }
                else
                {
                    Prop = Prop + "" + FirstCharToLower(modelname) + "." + colname + "  = " + dt.Columns[j].DataType.ToString() + ".Parse(datatable.Rows[i][\"" + colname + "\"].ToString()); " + Environment.NewLine;

                }


            }
            Prop = Prop + " list.Add(" + FirstCharToLower(modelname) + ");" + Environment.NewLine + "}" + Environment.NewLine + " return list ;" + Environment.NewLine + " }";




    
            ////Prop = Prop + "for (int j = 0; j < datatable.Columns.Count; j++)" + Environment.NewLine+ " { " + Environment.NewLine;


            ////Prop = Prop + "string colname = datatable.Columns[j].ColumnName;"+ Environment.NewLine;

            //rollPropertyViewmodel.AddedVia = datatable.Columns[j]["Addedvia"];

            return Prop;
        }



        public static DataTable ReturnQueryResultDatatable(String Qry)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=192.168.1.4;Initial Catalog=Art;User ID=sa;Password=Sreenath@123")) 
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = Qry;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                    }
                }
            }

            return dt;
        }
        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public static string FirstCharToLower(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToLower() + input.Substring(1);
            }
        }

        public String IndexCreator(DataTable dataTable,String Modelmasterlist)
        {
            string index = "<h2>Index</h2>" + Environment.NewLine + "";




            index = index + "<div class=\"form-horizontal\">" + Environment.NewLine + "<div class=\"form-group\"> " + Environment.NewLine + "<div class=\"control-label col-md-2\">ID : </div>" + Environment.NewLine + "";


            index = index + " <div class=\"col-md-4\"> @Html.DropDownList(\"ID\", null, htmlAttributes: new { @class = \"form-control\"}) </div>" + Environment.NewLine + "";
            index = index + "<div class=\"control-label col-md-2\">ID : </div>";
            index = index + " <div class=\"col-md-4\"> @Html.DropDownList(\"ID\", null, htmlAttributes: new { @class = \"form-control\"}) </div>" + Environment.NewLine + " </div> " + Environment.NewLine + "</div>" + Environment.NewLine + "";


       
       
   





            index = index + " <div id = 'loadingmessage' style = 'display:none' >" + Environment.NewLine + " <img src = '~/Image/ajax-loader.gif' alt=\"loading....\" />" + Environment.NewLine + " </div >" + Environment.NewLine;


            index = index + " @if(TempData[\"Success\"] != null)  {" + Environment.NewLine + " <div class=\"top-buffer\"></div>" + Environment.NewLine + " <div class=\"alert alert-success\">" + Environment.NewLine + "<p><strong>@TempData[\"Success\"].ToString()</strong></p>" + Environment.NewLine + " </div>}" + Environment.NewLine;
            index = index + " @if(TempData[\"Error\"] != null)  {" + Environment.NewLine + " <div class=\"top-buffer\"></div>" + Environment.NewLine + " <div class=\"alert alert-danger\">" + Environment.NewLine + "<p><strong>@TempData[\"Error\"].ToString()</strong></p>" + Environment.NewLine + " </div>}" + Environment.NewLine;



            index = index + "<table class=\"table table-responsive table-bordered table-striped MyDataTable\">  <thead> <tr>" + Environment.NewLine;





            string header = "";

            if (chk_isselected.Checked)
            {
                header = header + "<th>@Html.CheckBox(\"SelectAll\")</th>" + Environment.NewLine;
            }
            foreach (DataColumn col  in  dataTable.Columns)
            {

                header = header + " <th>" + @col.ColumnName + "</th>" + Environment.NewLine;

            }
            index = index + header + " </thead > <tbody >";

            index = index + "@foreach(var item in Model."+ Modelmasterlist + ") { <tr>" + Environment.NewLine;
            string body = "";

            if (chk_isselected.Checked)
            {
                body = body + "<td> @Html.EditorFor(modelItem => item.IsSelected, new { htmlAttributes = new { @class = \"IsSelected\" } })</td>" + Environment.NewLine;
            }
            foreach (DataColumn col in dataTable.Columns)
            {

                body = body + "<td class=" + col.ColumnName + "> @Html.DisplayFor(modelItem => item." +col.ColumnName+")</td>" + Environment.NewLine;

            }

            index = index + body + " </tr >    } " + Environment.NewLine + "  </tbody>" + Environment.NewLine + " </table>";



            index= index + " <script>" + Environment.NewLine+ " $(document).ready(function() { " + Environment.NewLine + " alert('@TempData[\"Error\"]');" + Environment.NewLine + "});" + Environment.NewLine + "</ script >";
            if (chk_isselected.Checked)
            {
                index = index + "$('#SelectAll').change(function() {" + Environment.NewLine;
                // this will contain a reference to the checkbox
                index = index + "  if (this.checked) { " + Environment.NewLine;
                // the checkbox is now checked

                index = index + "     var parenttable = $(this).closest('table'); " + Environment.NewLine;
                index = index + "      parenttable.children('tbody,tr,td').css('background-color', '#8AE1E9');" + Environment.NewLine;
                index = index + "  $(\"[id$=IsSelected]\").prop('checked', true);" + Environment.NewLine;
                index = index + "     getshortagesum();" + Environment.NewLine;

                index = index + "   } else {" + Environment.NewLine;


                index = index + "    if ($('[id$=IsSelected]:checked').length == $('[id$=IsSelected]').length) {" + Environment.NewLine;

                index = index + " $(\"[id$=IsSelected]\").prop('checked', false);" + Environment.NewLine;
                index = index + " parenttable.children('tbody,tr,td').css('background-color', '#F5F5F7')      }" + Environment.NewLine;
                // the checkbox is now no longer checked

                index = index + "     }" + Environment.NewLine;


                index = index + "   });" + Environment.NewLine;


                index = index + "  $(\"[id$=IsSelected]\").change(function() {" + Environment.NewLine;

                index = index + "      if (this.checked) {" + Environment.NewLine;

                index = index + "    $(this).closest('tr').children('td,th').css('background-color', '#8AE1E9');" + Environment.NewLine;
                index = index + "    }" + Environment.NewLine;
                index = index + " else {" + Environment.NewLine;
                index = index + "          $(this).closest('tr').children('td,th').css('background-color', '#F5F5F7');" + Environment.NewLine;

                index = index + "     }" + Environment.NewLine;




                index = index + "   });" + Environment.NewLine;


            }
            index = index + "<style>" + Environment.NewLine + ".top - buffer { margin - top: 20px; }" + Environment.NewLine + "</ style >";
            return index;
        }





        public String IndexCreatorPost(DataTable dataTable, String Modelmasterlist)
        {
            string index = "<h2>Index</h2>" + Environment.NewLine + "";




            index = index + "<div class=\"form-horizontal\">" + Environment.NewLine + "<div class=\"form-group\"> " + Environment.NewLine + "<div class=\"control-label col-md-2\">ID : </div>" + Environment.NewLine + "";


            index = index + " <div class=\"col-md-4\"> @Html.DropDownList(\"ID\", null, htmlAttributes: new { @class = \"form-control\"}) </div>" + Environment.NewLine + "";
            index = index + "<div class=\"control-label col-md-2\">ID : </div>";
            index = index + " <div class=\"col-md-4\"> @Html.DropDownList(\"ID\", null, htmlAttributes: new { @class = \"form-control\"}) </div>" + Environment.NewLine + " </div> " + Environment.NewLine + "</div>" + Environment.NewLine + "";










            index = index + " <div id = 'loadingmessage' style = 'display:none' >" + Environment.NewLine + " <img src = '~/Image/ajax-loader.gif' alt=\"loading....\" />" + Environment.NewLine + " </div >" + Environment.NewLine;


            index = index + " @if(TempData[\"Success\"] != null)  {" + Environment.NewLine + " <div class=\"top-buffer\"></div>" + Environment.NewLine + " <div class=\"alert alert-success\">" + Environment.NewLine + "<p><strong>@TempData[\"Success\"].ToString()</strong></p>" + Environment.NewLine + " </div>}" + Environment.NewLine;
            index = index + " @if(TempData[\"Error\"] != null)  {" + Environment.NewLine + " <div class=\"top-buffer\"></div>" + Environment.NewLine + " <div class=\"alert alert-danger\">" + Environment.NewLine + "<p><strong>@TempData[\"Error\"].ToString()</strong></p>" + Environment.NewLine + " </div>}" + Environment.NewLine;



            index = index + "<table class=\"table table-responsive table-bordered table-striped MyDataTable\">  <thead> <tr>" + Environment.NewLine;


            string header = "";
            if (chk_isselected.Checked)
            {
                header = header + "<th>@Html.CheckBox(\"SelectAll\")</th>" + Environment.NewLine;
            }

           
            foreach (DataColumn col in dataTable.Columns)
            {

                header = header + " <th>" + @col.ColumnName + "</th>" + Environment.NewLine;

            }
            index = index + header + " </thead > <tbody >" + Environment.NewLine;
            index = index + " @if(Model != null){for (int i = 0; i < Model." + Modelmasterlist + ".Count; i++){<tr>" + Environment.NewLine;

         
            string body = "";
           
            if (chk_isselected.Checked)
            {
                body = body  + "<td> @Html.EditorFor(modelItem => Model." + Modelmasterlist + "[i].IsSelected, new { htmlAttributes = new { @class = \"IsSelected\" } })</td>" + Environment.NewLine;
            }
            foreach (DataColumn col in dataTable.Columns)
            {
                

                body = body + "<td class=" + col.ColumnName + "> @Html.EditorFor(modelItem => Model." + Modelmasterlist + "[i]." + col.ColumnName + ")</td>" + Environment.NewLine;

            }

            index = index + body + " </tr >    } }" + Environment.NewLine + "  </tbody>" + Environment.NewLine + " </table>";



            index = index + " <script>" + Environment.NewLine + " $(document).ready(function() { " + Environment.NewLine +
                " alert('@TempData[\"Error\"]');" + Environment.NewLine + "});" + Environment.NewLine;






            if (chk_isselected.Checked)
            {
                index = index + "$('#SelectAll').change(function() {" + Environment.NewLine;
                // this will contain a reference to the checkbox
                index = index + "  if (this.checked) { " + Environment.NewLine;
                            // the checkbox is now checked

                         index = index + "     var parenttable = $(this).closest('table'); " + Environment.NewLine;
                        index = index + "      parenttable.children('tbody,tr,td').css('background-color', '#8AE1E9');" + Environment.NewLine;
                index = index + "  $(\"[id$=IsSelected]\").prop('checked', true);" + Environment.NewLine;
                index = index + "     getshortagesum();" + Environment.NewLine;

                index = index + "   } else {" + Environment.NewLine;


                index = index + "    if ($('[id$=IsSelected]:checked').length == $('[id$=IsSelected]').length) {" + Environment.NewLine;

                index = index + " $(\"[id$=IsSelected]\").prop('checked', false);" + Environment.NewLine;
                index = index + " parenttable.children('tbody,tr,td').css('background-color', '#F5F5F7')      }" + Environment.NewLine;
                // the checkbox is now no longer checked

                index = index + "     }" + Environment.NewLine;


                index = index + "   });" + Environment.NewLine;


                index = index + "  $(\"[id$=IsSelected]\").change(function() {" + Environment.NewLine;

                index = index + "      if (this.checked) {" + Environment.NewLine;

                index = index + "    $(this).closest('tr').children('td,th').css('background-color', '#8AE1E9');" + Environment.NewLine;
                index = index + "    }" + Environment.NewLine;
                index = index + " else {" + Environment.NewLine;
            index = index + "          $(this).closest('tr').children('td,th').css('background-color', '#F5F5F7');" + Environment.NewLine;

            index = index + "     }" + Environment.NewLine;




            index = index + "   });" + Environment.NewLine;


        }
                    index = index + "</script >";

            index = index + "<style>" + Environment.NewLine + ".top-buffer { margin-top: 20px; }" + Environment.NewLine + "</style >";
            return index;
        }






    }
}
