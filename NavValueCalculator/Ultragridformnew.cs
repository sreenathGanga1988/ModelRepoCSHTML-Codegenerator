using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NavValueCalculator
{
    public partial class Ultragridformnew : Form
    {
        public Ultragridformnew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //   dataGridView1.DataSource = GetCSFANew(DTP_FROM.Value.Date,DTP_TO.Value.Date,0);

            ultraGrid1.DataSource = GetCSFANewAtc(DTP_FROM.Value.Date, DTP_TO.Value.Date, 0);

           
        }



        //public DataTable manipulateData()
        //{
        //    DataTable dt = Getdata();
        //    dt.Columns.Add("CRatio");
        //    dt.Columns.Add("SRatio");
        //    dt.Columns.Add("FRatio");
        //    dt.Columns.Add("ARatio");


        //    dt.Columns.Add("Locked_CRatio");
        //    dt.Columns.Add("Locked_SRatio");
        //    dt.Columns.Add("Locked_FRatio");
        //    dt.Columns.Add("Locked_ARatio");







        //    foreach (DataRow row in dt.Rows)
        //    {
        //        Decimal cval = 0, sval = 0, fval = 0, aval = 0, ratiotot = 0, CRatio = 0, SRatio = 0, FRatio = 0, ARatio = 0,
        //            Locked_CRatio = 0, Locked_SRatio = 0, Locked_FRatio = 0, Locked_ARatio = 0, LockedCM = 0;                   ;

        //        try
        //        {
        //            cval = Decimal.Parse(row["C"].ToString());
        //        }
        //        catch (Exception)
        //        {


        //        }
        //        try
        //        {
        //            sval = Decimal.Parse(row["S"].ToString());
        //        }
        //        catch (Exception)
        //        {


        //        }
        //        try
        //        {
        //            fval = Decimal.Parse(row["F"].ToString());
        //        }
        //        catch (Exception)
        //        {


        //        }
        //        try { aval = Decimal.Parse(row["A"].ToString()); }catch (Exception){  }
        //        try { LockedCM = Decimal.Parse(row["LockedCM"].ToString()); } catch (Exception) { }                
        //        ratiotot = aval + fval + sval + cval;
        //        try { CRatio = (cval / ratiotot) * 100; } catch (Exception) { }
        //       try { SRatio = (sval / ratiotot) * 100; } catch (Exception) { }
        //        try {  FRatio = (fval / ratiotot) * 100; } catch (Exception) { }
        //        try {  ARatio = (aval / ratiotot) * 100; } catch (Exception) { }


        //        try { Locked_CRatio = (LockedCM / 100) * CRatio; } catch (Exception) { }
        //        try { Locked_SRatio = (LockedCM / 100) * SRatio; } catch (Exception) { }
        //        try { Locked_FRatio = (LockedCM / 100) * FRatio; } catch (Exception) { }
        //        try { Locked_ARatio = (LockedCM / 100) * ARatio; } catch (Exception) { }

        //        row["CRatio"] = CRatio;
        //        row["SRatio"] = SRatio;
        //        row["FRatio"] = FRatio;
        //        row["ARatio"] = ARatio;
        //        row["Locked_CRatio"] = Locked_CRatio;
        //        row["Locked_SRatio"] = Locked_SRatio;
        //        row["Locked_FRatio"] = Locked_FRatio;
        //        row["Locked_ARatio"] = Locked_ARatio;
        //    }
        //    return dt;

        //}


        public DataTable GetCSFANewAtc(DateTime fromdate, DateTime todate, int atcid = 0)
        {



            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(@"CSFAData"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fromdate", fromdate);
                cmd.Parameters.AddWithValue("@todate", todate);
                dt = ReturnQueryResultDatatableforSP(cmd);
            }
          //  dt = dt.Select("OurStyleId=802").CopyToDataTable();





            dt.Columns.Add("CRatio");
            dt.Columns.Add("SRatio");
            dt.Columns.Add("FRatio");
            dt.Columns.Add("ARatio");


            dt.Columns.Add("Locked_CRatio");
            dt.Columns.Add("Locked_SRatio");
            dt.Columns.Add("Locked_FRatio");
            dt.Columns.Add("Locked_ARatio");


            dt.Columns.Add("Locked_TotValue", typeof(Decimal));


            

            foreach (DataRow row in dt.Rows)
            {
                Decimal cval = 0, sval = 0, fval = 0, aval = 0, ratiotot = 0, CRatio = 0, SRatio = 0, FRatio = 0, ARatio = 0,
                    Locked_CRatio = 0, Locked_SRatio = 0, Locked_FRatio = 0, Locked_ARatio = 0, LockedCM = 0,
                Locked_CValue = 0, Locked_SValue = 0, Locked_FValue = 0, Locked_AValue = 0, TTLSAM = 0; ;
                int ourstyleid = int.Parse(row["OurStyleId"].ToString());

                if(ourstyleid==802)
                {
                    int k = ourstyleid;
                }

                try
                {
                    cval = Decimal.Parse(row["C"].ToString());
                }
                catch (Exception)
                {


                }
                try
                {
                    sval = Decimal.Parse(row["S"].ToString());
                }
                catch (Exception)
                {


                }
                try
                {
                    fval = Decimal.Parse(row["F"].ToString());
                }
                catch (Exception)
                {


                }
                try { aval = Decimal.Parse(row["A"].ToString()); } catch (Exception) { }
                try { LockedCM = Decimal.Parse(row["LockedCM"].ToString()); } catch (Exception) { }

                try { TTLSAM = Decimal.Parse(row["TTLSAM"].ToString()); } catch (Exception) { }

                ratiotot = TTLSAM;
                //ratiotot = aval + fval + sval + cval;
                try { CRatio = (cval / ratiotot) * 100; } catch (Exception) { }
                try { SRatio = (sval / ratiotot) * 100; } catch (Exception) { }
                try { FRatio = (fval / ratiotot) * 100; } catch (Exception) { }
                try { ARatio = (aval / ratiotot) * 100; } catch (Exception) { }


                try { Locked_CRatio = (LockedCM / 100) * CRatio; } catch (Exception) { }
                try { Locked_SRatio = (LockedCM / 100) * SRatio; } catch (Exception) { }
                try { Locked_FRatio = (LockedCM / 100) * FRatio; } catch (Exception) { }
                try { Locked_ARatio = (LockedCM / 100) * ARatio; } catch (Exception) { }









                row["CRatio"] = CRatio;
                row["SRatio"] = SRatio;
                row["FRatio"] = FRatio;
                row["ARatio"] = ARatio;
                row["Locked_CRatio"] = Math.Round(Decimal.Parse(Locked_CRatio.ToString()), 5); 
                row["Locked_SRatio"] = Math.Round(Decimal.Parse(Locked_SRatio.ToString()), 5);
                row["Locked_FRatio"] = Math.Round(Decimal.Parse(Locked_FRatio.ToString()), 5);
                row["Locked_ARatio"] = Math.Round(Decimal.Parse(Locked_ARatio.ToString()), 5);



                Decimal ProducedGarment = Decimal.Parse(row["ProducedGarment"].ToString());
                Decimal ReveneuVal = 0;

                int DeptID = int.Parse(row["DeptID"].ToString());
                Decimal multratio = 0;
                if (DeptID == 2) { multratio = Locked_CRatio; }
                else if (DeptID == 5) { multratio = Locked_FRatio; }
                else if (DeptID == 6) { multratio = Locked_ARatio; } else if (DeptID == 3) { multratio = Locked_SRatio; }
                ReveneuVal = multratio * ProducedGarment;

                row["Locked_TotValue"] = ReveneuVal;

            }





            DataView view = new DataView(dt);
            DataTable distinctValues = view.ToTable(true, "LocationName", "Location_pk", "OurStyle", "OurStyleID", "LockedCM", "CRatio", "SRatio", "FRatio", "ARatio", "Locked_CRatio", "Locked_SRatio", "Locked_FRatio", "Locked_ARatio");

            distinctValues.Columns.Add("JCM",typeof(Decimal));
            distinctValues.Columns.Add("CutQty", typeof(Decimal));
            distinctValues.Columns.Add("CutValue", typeof(Decimal));
            distinctValues.Columns.Add("CutJCMValue", typeof(Decimal));



            distinctValues.Columns.Add("SewQty", typeof(Decimal));
            distinctValues.Columns.Add("SewValue", typeof(Decimal));
            distinctValues.Columns.Add("SewJCMValue", typeof(Decimal));


            distinctValues.Columns.Add("FinishingQty", typeof(Decimal));
            distinctValues.Columns.Add("Finishingvalue", typeof(Decimal));
            distinctValues.Columns.Add("FinishingJCMValue", typeof(Decimal));


            distinctValues.Columns.Add("AirPortQty", typeof(Decimal));
            distinctValues.Columns.Add("AirportValue", typeof(Decimal));
            distinctValues.Columns.Add("AirportJCMValue", typeof(Decimal));

            distinctValues.Columns.Add("Total", typeof(Decimal));
            distinctValues.Columns.Add("JCMtotalvalue", typeof(Decimal));
            distinctValues.Columns.Add("Diff", typeof(Decimal));
            foreach (DataRow row in distinctValues.Rows)
            {
                int Location_pk = int.Parse(row["Location_pk"].ToString());
                //DateTime effDate = DateTime.Parse(row["effDate"].ToString());
                int OurStyleID = int.Parse(row["OurStyleID"].ToString());



                try
                {
                    var JCM = dt.Compute("max(JCM)", " Location_pk=" + Location_pk + " and DeptID=2  and OurStyleID=" + OurStyleID + "");
                    row["JCM"] = Decimal.Parse(JCM.ToString());
                }
                catch (Exception)
                {

                    row["JCM"] = 0;
                }






                #region Cut

                try
                {
                    var cutQtyqry = dt.Compute("Sum(ProducedGarment)", " Location_pk=" + Location_pk + " and DeptID=2  and OurStyleID=" + OurStyleID + "");
                    row["CutQty"] = Decimal.Parse(cutQtyqry.ToString());
                }
                catch (Exception)
                {

                    row["CutQty"] = 0;
                }
                try
                {
                    var cutValqry = dt.Compute("Sum(Locked_TotValue)", "Location_pk=" + Location_pk + " and DeptID=2 and OurStyleID=" + OurStyleID + "");
                    row["CutValue"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["CutValue"] = 0;
                }
                try
                {
                    var cutValqry = dt.Compute("Sum(Revenue)", "Location_pk=" + Location_pk + " and DeptID=2 and OurStyleID=" + OurStyleID + "");
                    row["CutJCMValue"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["CutJCMValue"] = 0;
                }

                try
                {
                    var cutValqry = dt.Compute("Max(DeptCM)", "Location_pk=" + Location_pk + " and DeptID=2 and OurStyleID=" + OurStyleID + "");
                    row["CRatio"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["CRatio"] = 0;
                }
                #endregion

                #region Sew

                try
                {
                    var SewQtyqry = dt.Compute("Sum(ProducedGarment)", "Location_pk=" + Location_pk + " and DeptID=3 and OurStyleID=" + OurStyleID + "");
                    row["SewQty"] = Decimal.Parse(SewQtyqry.ToString());
                }
                catch (Exception)
                {

                    row["SewQty"] = 0;
                }
                try
                {
                    var SewValqry = dt.Compute("Sum(Locked_TotValue)", "Location_pk=" + Location_pk + " and DeptID=3 and OurStyleID=" + OurStyleID + "");
                    row["SewValue"] = Decimal.Parse(SewValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["SewValue"] = 0;
                }
                try
                {
                    var cutValqry = dt.Compute("Sum(Revenue)", " Location_pk=" + Location_pk + " and DeptID=3 and OurStyleID=" + OurStyleID + "");
                    row["SewJCMValue"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["SewJCMValue"] = 0;
                }
                try
                {
                    var cutValqry = dt.Compute("Max(DeptCM)", " Location_pk=" + Location_pk + " and DeptID=3 and OurStyleID=" + OurStyleID + "");
                    row["SRatio"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["SRatio"] = 0;
                }
                #endregion


                #region AirPort

                try
                {
                    var AirPortQtyqry = dt.Compute("Sum(ProducedGarment)", " Location_pk=" + Location_pk + " and DeptID=6 and OurStyleID=" + OurStyleID + "");
                    row["AirPortQty"] = Decimal.Parse(AirPortQtyqry.ToString());
                }
                catch (Exception)
                {

                    row["AirPortQty"] = 0;
                }
                try
                {
                    var AirPortValqry = dt.Compute("Sum(Locked_TotValue)", " Location_pk=" + Location_pk + " and DeptID=6 and OurStyleID=" + OurStyleID + "");
                    row["AirPortValue"] = Decimal.Parse(AirPortValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["AirPortValue"] = 0;
                }
                try
                {
                    var cutValqry = dt.Compute("Sum(Revenue)", "Location_pk=" + Location_pk + " and DeptID=6 and OurStyleID=" + OurStyleID + "");
                    row["AirportJCMValue"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["AirportJCMValue"] = 0;
                }
                try
                {
                    var cutValqry = dt.Compute("Max(DeptCM)", " Location_pk=" + Location_pk + " and DeptID=6 and OurStyleID=" + OurStyleID + "");
                    row["ARatio"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["ARatio"] = 0;
                }
                #endregion






                #region Finishing

                try
                {
                    var Finishingqry = dt.Compute("Sum(ProducedGarment)", "Location_pk=" + Location_pk + " and DeptID=5 and OurStyleID=" + OurStyleID + "");
                    row["FinishingQty"] = Decimal.Parse(Finishingqry.ToString());
                }
                catch (Exception)
                {

                    row["FinishingQty"] = 0;
                }
                try
                {
                    var FinishingValqry = dt.Compute("Sum(Locked_TotValue)", " Location_pk=" + Location_pk + " and DeptID=5 and OurStyleID=" + OurStyleID + "");
                    row["FinishingValue"] = Decimal.Parse(FinishingValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["FinishingValue"] = 0;
                }


                try
                {
                    var cutValqry = dt.Compute("Sum(Revenue)", " Location_pk=" + Location_pk + " and DeptID=5 and OurStyleID=" + OurStyleID + "");
                    row["FinishingJCMValue"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["FinishingJCMValue"] = 0;
                }
                try
                {
                    var cutValqry = dt.Compute("Max(DeptCM)", " Location_pk=" + Location_pk + " and DeptID=5 and OurStyleID=" + OurStyleID + "");
                    row["FRatio"] = Decimal.Parse(cutValqry.ToString());
                }
                catch (Exception ex)
                {

                    row["FRatio"] = 0;
                }
                #endregion


                #region JCMValue

                try
                {
                    var jcmvalue = dt.Compute("Sum(Revenue)", "Location_pk=" + Location_pk + "and OurStyleID=" + OurStyleID + "");
                    row["JCMtotalvalue"] = Decimal.Parse(jcmvalue.ToString());
                }
                catch (Exception ex)
                {

                    row["JCMtotalvalue"] = 0;
                }


                #endregion

                Decimal total = Decimal.Parse(row["FinishingValue"].ToString()) + Decimal.Parse(row["AirPortValue"].ToString())
                    + Decimal.Parse(row["SewValue"].ToString()) + Decimal.Parse(row["CutValue"].ToString());

                row["Total"] = Decimal.Parse(total.ToString());


                row["Diff"] = Decimal.Parse(row["Total"].ToString()) - Decimal.Parse(row["JCMtotalvalue"].ToString());


            }





            distinctValues.Columns["Location_pk"].SetOrdinal(0);
            distinctValues.Columns["OurStyleID"].SetOrdinal(1);
            distinctValues.Columns["LocationName"].SetOrdinal(2);
            distinctValues.Columns["OurStyle"].SetOrdinal(3);
            distinctValues.Columns["jcm"].SetOrdinal(4);
            distinctValues.Columns["LockedCM"].SetOrdinal(5);
            distinctValues.Columns["CutQty"].SetOrdinal(6);
            distinctValues.Columns["CRatio"].SetOrdinal(7);
            distinctValues.Columns["CutJCMValue"].SetOrdinal(8);
            distinctValues.Columns["Locked_CRatio"].SetOrdinal(9);
            distinctValues.Columns["CutValue"].SetOrdinal(10);
            distinctValues.Columns["SewQty"].SetOrdinal(11);
            distinctValues.Columns["SRatio"].SetOrdinal(12);
            distinctValues.Columns["SewJCMValue"].SetOrdinal(13);
            distinctValues.Columns["Locked_SRatio"].SetOrdinal(14);
            distinctValues.Columns["SewValue"].SetOrdinal(15);
            distinctValues.Columns["FinishingQty"].SetOrdinal(16);
            distinctValues.Columns["FRatio"].SetOrdinal(17);
            distinctValues.Columns["FinishingJCMValue"].SetOrdinal(18);
            distinctValues.Columns["Locked_FRatio"].SetOrdinal(19);
            distinctValues.Columns["Finishingvalue"].SetOrdinal(20);
            distinctValues.Columns["AirPortQty"].SetOrdinal(21);
            distinctValues.Columns["ARatio"].SetOrdinal(22);
            distinctValues.Columns["AirportJCMValue"].SetOrdinal(23);
            distinctValues.Columns["Locked_ARatio"].SetOrdinal(24);
            distinctValues.Columns["AirportValue"].SetOrdinal(25);
            distinctValues.Columns["Total"].SetOrdinal(26);
            distinctValues.Columns["JCMtotalvalue"].SetOrdinal(27);
            distinctValues.Columns["Diff"].SetOrdinal(28);


            return distinctValues;
        }




        //public DataTable GetCSFANew(DateTime fromdate, DateTime todate, int atcid = 0)
        //{



        //    DataTable dt = new DataTable();
        //    using (SqlCommand cmd = new SqlCommand(@"CSFAData"))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@fromdate", fromdate);
        //        cmd.Parameters.AddWithValue("@todate", todate);
        //        dt = ReturnQueryResultDatatableforSP(cmd);
        //    }






        //    dt.Columns.Add("CRatio");
        //    dt.Columns.Add("SRatio");
        //    dt.Columns.Add("FRatio");
        //    dt.Columns.Add("ARatio");


        //    dt.Columns.Add("Locked_CRatio");
        //    dt.Columns.Add("Locked_SRatio");
        //    dt.Columns.Add("Locked_FRatio");
        //    dt.Columns.Add("Locked_ARatio");



        //    dt.Columns.Add("Locked_TotValue", typeof(Decimal));




        //    foreach (DataRow row in dt.Rows)
        //    {
        //        Decimal cval = 0, sval = 0, fval = 0, aval = 0, ratiotot = 0, CRatio = 0, SRatio = 0, FRatio = 0, ARatio = 0,
        //            Locked_CRatio = 0, Locked_SRatio = 0, Locked_FRatio = 0, Locked_ARatio = 0, LockedCM = 0,
        //        Locked_CValue = 0, Locked_SValue = 0, Locked_FValue = 0, Locked_AValue = 0;

        //        try
        //        {
        //            cval = Decimal.Parse(row["C"].ToString());
        //        }
        //        catch (Exception)
        //        {


        //        }
        //        try
        //        {
        //            sval = Decimal.Parse(row["S"].ToString());
        //        }
        //        catch (Exception)
        //        {


        //        }
        //        try
        //        {
        //            fval = Decimal.Parse(row["F"].ToString());
        //        }
        //        catch (Exception)
        //        {


        //        }
        //        try { aval = Decimal.Parse(row["A"].ToString()); } catch (Exception) { }
        //        try { LockedCM = Decimal.Parse(row["LockedCM"].ToString()); } catch (Exception) { }
        //        ratiotot = aval + fval + sval + cval;
        //        try { CRatio = (cval / ratiotot) * 100; } catch (Exception) { }
        //        try { SRatio = (sval / ratiotot) * 100; } catch (Exception) { }
        //        try { FRatio = (fval / ratiotot) * 100; } catch (Exception) { }
        //        try { ARatio = (aval / ratiotot) * 100; } catch (Exception) { }


        //        try { Locked_CRatio = (LockedCM / 100) * CRatio; } catch (Exception) { }
        //        try { Locked_SRatio = (LockedCM / 100) * SRatio; } catch (Exception) { }
        //        try { Locked_FRatio = (LockedCM / 100) * FRatio; } catch (Exception) { }
        //        try { Locked_ARatio = (LockedCM / 100) * ARatio; } catch (Exception) { }









        //        row["CRatio"] = CRatio;
        //        row["SRatio"] = SRatio;
        //        row["FRatio"] = FRatio;
        //        row["ARatio"] = ARatio;
        //        row["Locked_CRatio"] = Locked_CRatio;
        //        row["Locked_SRatio"] = Locked_SRatio;
        //        row["Locked_FRatio"] = Locked_FRatio;
        //        row["Locked_ARatio"] = Locked_ARatio;



        //        Decimal ProducedGarment = Decimal.Parse(row["ProducedGarment"].ToString());
        //        Decimal ReveneuVal = 0;

        //        int DeptID = int.Parse(row["DeptID"].ToString());
        //        Decimal multratio = 0;
        //        if (DeptID == 2) { multratio = Locked_CRatio; }
        //        else if (DeptID == 5) { multratio = Locked_FRatio; }
        //        else if (DeptID == 6) { multratio = Locked_ARatio; } else if (DeptID == 3) { multratio = Locked_SRatio; }
        //        ReveneuVal = multratio * ProducedGarment;

        //        row["Locked_TotValue"] = ReveneuVal;

        //    }





        //    DataView view = new DataView(dt);
        //    DataTable distinctValues = view.ToTable(true, "LocationName", "effDate", "Location_pk");
        //    distinctValues.Columns.Add("CutQty");
        //    distinctValues.Columns.Add("CutValue");
        //    distinctValues.Columns.Add("SewQty");
        //    distinctValues.Columns.Add("SewValue");


        //    distinctValues.Columns.Add("FinishingQty");
        //    distinctValues.Columns.Add("Finishingvalue");
        //    distinctValues.Columns.Add("AirPortQty");
        //    distinctValues.Columns.Add("AirportValue");


        //    distinctValues.Columns.Add("Total");
        //    distinctValues.Columns.Add("JCMtotalvalue");
        //    distinctValues.Columns.Add("Diff");
        //    foreach (DataRow row in distinctValues.Rows)
        //    {
        //        int Location_pk = int.Parse(row["Location_pk"].ToString());
        //        DateTime effDate = DateTime.Parse(row["effDate"].ToString());


        //        #region Cut

        //        try
        //        {
        //            var cutQtyqry = dt.Compute("Sum(ProducedGarment)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=2 ");
        //            row["CutQty"] = Decimal.Parse(cutQtyqry.ToString()).ToString("F");
        //        }
        //        catch (Exception)
        //        {

        //            row["CutQty"] = 0;
        //        }
        //        try
        //        {
        //            var cutValqry = dt.Compute("Sum(Locked_TotValue)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=2 ");
        //            row["CutValue"] = Decimal.Parse(cutValqry.ToString()).ToString("F");
        //        }
        //        catch (Exception ex)
        //        {

        //            row["CutValue"] = 0;
        //        }
        //        #endregion



        //        #region Sew

        //        try
        //        {
        //            var SewQtyqry = dt.Compute("Sum(ProducedGarment)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=3 ");
        //            row["SewQty"] = Decimal.Parse(SewQtyqry.ToString()).ToString("F");
        //        }
        //        catch (Exception)
        //        {

        //            row["SewQty"] = 0;
        //        }
        //        try
        //        {
        //            var SewValqry = dt.Compute("Sum(Locked_TotValue)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=3 ");
        //            row["SewValue"] = Decimal.Parse(SewValqry.ToString()).ToString("F");
        //        }
        //        catch (Exception ex)
        //        {

        //            row["SewValue"] = 0;
        //        }
        //        #endregion


        //        #region AirPort

        //        try
        //        {
        //            var AirPortQtyqry = dt.Compute("Sum(ProducedGarment)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=6 ");
        //            row["AirPortQty"] = Decimal.Parse(AirPortQtyqry.ToString()).ToString("F");
        //        }
        //        catch (Exception)
        //        {

        //            row["AirPortQty"] = 0;
        //        }
        //        try
        //        {
        //            var AirPortValqry = dt.Compute("Sum(Locked_TotValue)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=6");
        //            row["AirPortValue"] = Decimal.Parse(AirPortValqry.ToString()).ToString("F");
        //        }
        //        catch (Exception ex)
        //        {

        //            row["AirPortValue"] = 0;
        //        }
        //        #endregion






        //        #region Finishing

        //        try
        //        {
        //            var Finishingqry = dt.Compute("Sum(ProducedGarment)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=5 ");
        //            row["FinishingQty"] = Decimal.Parse(Finishingqry.ToString()).ToString("F");
        //        }
        //        catch (Exception)
        //        {

        //            row["FinishingQty"] = 0;
        //        }
        //        try
        //        {
        //            var FinishingValqry = dt.Compute("Sum(Locked_TotValue)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + " and DeptID=5 ");
        //            row["FinishingValue"] = Decimal.Parse(FinishingValqry.ToString()).ToString("F");
        //        }
        //        catch (Exception ex)
        //        {

        //            row["FinishingValue"] = 0;
        //        }
        //        #endregion


        //        #region JCMValue

        //        try
        //        {
        //            var jcmvalue = dt.Compute("Sum(Revenue)", "effDate ='" + effDate + "' and Location_pk=" + Location_pk + "");
        //            row["JCMtotalvalue"] = Decimal.Parse(jcmvalue.ToString()).ToString("F");
        //        }
        //        catch (Exception ex)
        //        {

        //            row["JCMtotalvalue"] = 0;
        //        }


        //        #endregion

        //        Decimal total = Decimal.Parse(row["FinishingValue"].ToString()) + Decimal.Parse(row["AirPortValue"].ToString())
        //            + Decimal.Parse(row["SewValue"].ToString()) + Decimal.Parse(row["CutValue"].ToString());

        //        row["Total"] = total.ToString("F");


        //        row["Diff"] = Decimal.Parse(row["Total"].ToString()) - Decimal.Parse(row["JCMtotalvalue"].ToString());


        //    }





        //    return distinctValues;
        //}





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

        public static DataTable ReturnQueryResultDatatableforSP(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=192.168.1.4;Initial Catalog=Art;User ID=sa;Password=Sreenath@123"))
            {
                cmd.Connection = con;
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                dt.Load(rdr);
            }

            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.ultraGridExcelExporter1.Export(this.ultraGrid1, "D:\\GridData.xls")

               
                ;
            MessageBox.Show("Exported");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          

            //dATAeXPORTER dATAeXPORTER = new dATAeXPORTER();
            //dATAeXPORTER.ExportToExcelWithFormat(ultraGrid1);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done");
         
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
    }
}
