using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExcelDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string path = fil.FileName.ToString();
            ExcelFileReader(path);
        }

        public void ExcelFileReader(string path)
        {
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var reault = reader.AsDataSet();
            var tables = reault.Tables.Cast<DataTable>();   

            foreach ( var table in tables)
            {
              //  dataGridView1.DataSource= table;    
            }


            reader.Close();

        }

        private void foodBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();

            //string jsonPath = "C:\\Users\\larsw\\Downloads\\output.txt";

            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\Food\\FoodAsJSON.txt";


             FoodToJSON(excelPath, jsonPath);

            MessageBox.Show("Done !");
        }


        public void FoodToJSON(string inputFile, String outputFile)
        {

            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                do
                {
                    while (reader.Read())
                    {
                        //We don't need an empty object
                        var foodNameDK = reader.GetString(0);
                        if (string.IsNullOrEmpty(foodNameDK)) break;

                        writer.WriteStartObject();
                        //Select Columns and values
                        writer.WritePropertyName("NameDK");
                        writer.WriteValue(foodNameDK);


                        var foodNameENG = reader.GetString(1);
                        if (string.IsNullOrEmpty(foodNameENG))
                        {
                            foodNameENG = string.Empty;
                        }
                        writer.WritePropertyName("NameENG");
                        writer.WriteValue(foodNameENG);


                        var foodId = reader.GetDouble(2).ToString();
                        if (string.IsNullOrEmpty(foodId))
                        {
                            foodId = string.Empty;
                        }
                        writer.WritePropertyName("Id");
                        writer.WriteValue(foodId);

                        var taxonomicName = reader.GetString(3);
                        if (string.IsNullOrEmpty(taxonomicName))
                        {
                            taxonomicName = string.Empty;
                        }
                        writer.WritePropertyName("TaxonomicName");
                        writer.WriteValue(taxonomicName);

                        var FoodEx2Code = reader.GetString(4);
                        if (string.IsNullOrEmpty(FoodEx2Code))
                        {
                            FoodEx2Code = string.Empty;
                        }
                        writer.WritePropertyName("FoodEx2Code");
                        writer.WriteValue(FoodEx2Code);

                        var foodGroupId = reader.GetDouble(5).ToString();
                        if (string.IsNullOrEmpty(foodGroupId))
                        {
                            foodGroupId = string.Empty;
                        }
                        writer.WritePropertyName("FoodGroupId");
                        writer.WriteValue(foodGroupId);

                       
                        writer.WritePropertyName("FoodSourceId");
                        writer.WriteValue("1"); 







                        /*
                        writer.WritePropertyName("Gender");
                        writer.WriteValue(reader.GetString(2));

                        writer.WritePropertyName("State");
                        writer.WriteValue(reader.GetString(3));
                        */
                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }



            //reader.Close();

        }


        public void FoodToJSONnew(string inputFile, String outputFile)
        {
            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                do
                {
                    while (reader.Read())
                    {
                        //We don't need an empty object
                        var foodNameDK = reader.GetString(0);
                        if (string.IsNullOrEmpty(foodNameDK)) break;

                        writer.WriteStartObject();
                        //Select Columns and values
                        writer.WritePropertyName("FoodNameDK");
                        writer.WriteValue(foodNameDK);


                        var foodNameENG = reader.GetString(1);
                        if (string.IsNullOrEmpty(foodNameENG))
                        {
                            foodNameENG = string.Empty;
                        }
                        writer.WritePropertyName("FoodNameENG");
                        writer.WriteValue(foodNameENG);


                        var foodId = reader.GetDouble(2).ToString();
                        if (string.IsNullOrEmpty(foodId))
                        {
                            foodId = string.Empty;
                        }
                        writer.WritePropertyName("FoodId");
                        writer.WriteValue(foodId);

                        var taxonomicName = reader.GetString(3);
                        if (string.IsNullOrEmpty(taxonomicName))
                        {
                            taxonomicName = string.Empty;
                        }
                        writer.WritePropertyName("TaxonomicName");
                        writer.WriteValue(taxonomicName);

                        var FoodEx2Code = reader.GetString(4);
                        if (string.IsNullOrEmpty(FoodEx2Code))
                        {
                            FoodEx2Code = string.Empty;
                        }
                        writer.WritePropertyName("FoodEx2Code");
                        writer.WriteValue(FoodEx2Code);

                        var foodGroupId = reader.GetDouble(5).ToString();
                        if (string.IsNullOrEmpty(foodGroupId))
                        {
                            foodGroupId = string.Empty;
                        }
                        writer.WritePropertyName("FoodGroupId");
                        writer.WriteValue(foodGroupId);

                        var foodGroupNameDk = reader.GetString(6);
                        if (string.IsNullOrEmpty(foodGroupNameDk))
                        {
                            foodGroupNameDk = string.Empty;
                        }
                        writer.WritePropertyName("FoodGroupNameDk");
                        writer.WriteValue(foodGroupNameDk);

                        var foodGroupNameEng = reader.GetString(7);
                        if (string.IsNullOrEmpty(foodGroupNameEng))
                        {
                            foodGroupNameEng = string.Empty;
                        }
                        writer.WritePropertyName("FoodGroupNameEng");
                        writer.WriteValue(foodGroupNameEng);







                        /*
                        writer.WritePropertyName("Gender");
                        writer.WriteValue(reader.GetString(2));

                        writer.WritePropertyName("State");
                        writer.WriteValue(reader.GetString(3));
                        */
                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }



            //reader.Close();

        }

        private void ParametersToJSON(string inputFile, string outputFile)
        {
            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                do
                {
                    while (reader.Read())
                    {
                        //We don't need an empty object
                        var parameterNameDK = reader.GetString(0);
                        if (string.IsNullOrEmpty(parameterNameDK)) break;

                        writer.WriteStartObject();
                        //Select Columns and values
                        writer.WritePropertyName("NameDK");
                        writer.WriteValue(parameterNameDK);


                        var parameterNameENG = reader.GetString(1);
                        if (string.IsNullOrEmpty(parameterNameENG))
                        {
                            parameterNameENG = string.Empty;
                        }
                        writer.WritePropertyName("NameENG");
                        writer.WriteValue(parameterNameENG);

                        //Set parameterUnitId:

                        var unit = reader.GetString(2);
                        if (string.IsNullOrEmpty(unit))
                        {
                            unit = string.Empty;
                        }

                        if(unit.Equals("kJ/100g")) unit= "1";
                        else if(unit.Equals("kcal/100 g")) unit= "2";
                        else if (unit.Equals("g/100g")) unit = "3";
                        else if (unit.Equals("RE (µg/100g)")) unit = "4";
                        else if (unit.Equals("µg/100g")) unit = "5";
                        else if (unit.Equals("alfa-TE")) unit = "6";
                        else if (unit.Equals("mg/100g")) unit = "7";
                        else if (unit.Equals("NE")) unit = "8";
                        else if (unit.Equals("%")) unit = "9";
                        else if (unit.Equals("No Unit")) unit = "10";
                        else unit = "10";

                        writer.WritePropertyName("UnitId");
                        writer.WriteValue(unit);

                        var sortKey = reader.GetDouble(3).ToString();
                        if (string.IsNullOrEmpty(sortKey))
                        {
                            sortKey = string.Empty;
                        }
                        writer.WritePropertyName("SortKey");
                        writer.WriteValue(sortKey);

                        var parameterId = reader.GetDouble(4).ToString();
                        if (string.IsNullOrEmpty(parameterId))
                        {
                            parameterId = string.Empty;
                        }
                        writer.WritePropertyName("Id");
                        writer.WriteValue(parameterId);

                        var euroFIR_Code = reader.GetString(5);
                        if (string.IsNullOrEmpty(euroFIR_Code))
                        {
                            euroFIR_Code = string.Empty;
                        }
                        writer.WritePropertyName("EuroFIR_Code");
                        writer.WriteValue(euroFIR_Code);

                        var eFSA_PARAM_Code = reader.GetString(6);
                        if (string.IsNullOrEmpty(eFSA_PARAM_Code))
                        {
                            eFSA_PARAM_Code = string.Empty;
                        }
                        writer.WritePropertyName("EFSA_PARAM_Code");
                        writer.WriteValue(eFSA_PARAM_Code);

                        var parameterGroupId = reader.GetDouble(7).ToString();
                        if (string.IsNullOrEmpty(parameterGroupId))
                        {
                            parameterGroupId = string.Empty;
                        }
                        writer.WritePropertyName("ParameterGroupId");
                        writer.WriteValue(parameterGroupId);

                        /*
                        var parameterGroupNameDk = reader.GetString(8);
                        if (string.IsNullOrEmpty(parameterGroupNameDk))
                        {
                            parameterGroupNameDk = string.Empty;
                        }
                        writer.WritePropertyName("ParameterGroupNameDk");
                        writer.WriteValue(parameterGroupNameDk);

                        var parameterGroupNameEng = reader.GetString(9);
                        if (string.IsNullOrEmpty(parameterGroupNameEng))
                        {
                            parameterGroupNameEng = string.Empty;
                        }
                        writer.WritePropertyName("ParameterGroupNameEng");
                        writer.WriteValue(parameterGroupNameEng);
                        */

                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }


        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void parametersBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();

            //string jsonPath = "C:\\Users\\larsw\\Downloads\\output.txt";

            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\Parameter\\ParametersAsJSON.txt";

        
            ParametersToJSON(excelPath, jsonPath);

            MessageBox.Show("Done !");
        }

      

        private void foodbtn_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();

            //string jsonPath = "C:\\Users\\larsw\\Downloads\\output.txt";

            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\FoodAsJSONnew.txt";

            FoodToJSONnew(excelPath, jsonPath);

            MessageBox.Show("Done !");

        }

        private void convertSourcesBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();


            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\Source\\SourcesAsJSON.txt";


            SourcesToJSON(excelPath, jsonPath);

            MessageBox.Show("Done !");

        }

        private void SourcesToJSON(string inputFile, string outputFile)
        {
            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                do
                {
                    while (reader.Read())
                    {
                        //We don't need an empty object
                        var sourceId = reader.GetDouble(0).ToString();
                        if (string.IsNullOrEmpty(sourceId)) break;

                        writer.WriteStartObject();
                        //Select Columns and values
                        writer.WritePropertyName("SourceId");
                        writer.WriteValue(sourceId);


                        var eurofirRefType = reader.GetString(1);
                        if (string.IsNullOrEmpty(eurofirRefType))
                        {
                            eurofirRefType = string.Empty;
                        }
                        writer.WritePropertyName("EurofirRefType");
                        writer.WriteValue(eurofirRefType);


                        var uRL = reader.GetString(2);
                        if (string.IsNullOrEmpty(uRL))
                        {
                            uRL = string.Empty;
                        }
                        writer.WritePropertyName("URL");
                        writer.WriteValue(uRL);

                        var language = reader.GetString(3);
                        if (string.IsNullOrEmpty(language))
                        {
                            language = string.Empty;
                        }
                        writer.WritePropertyName("Language");
                        writer.WriteValue(language);


                        var titleDk = reader.GetString(4);
                        if (string.IsNullOrEmpty(titleDk))
                        {
                            titleDk = string.Empty;
                        }
                        writer.WritePropertyName("TitleDk");
                        writer.WriteValue(titleDk);

                        var titleEng = reader.GetString(5);
                        if (string.IsNullOrEmpty(titleEng))
                        {
                            titleEng = string.Empty;
                        }
                        writer.WritePropertyName("TitleEng");
                        writer.WriteValue(titleEng);

                        var publisher = reader.GetString(6);
                        if (string.IsNullOrEmpty(publisher))
                        {
                            publisher = string.Empty;
                        }
                        writer.WritePropertyName("Publisher");
                        writer.WriteValue(publisher);




                        var reportNumber = reader.GetValue(7);
                        if (!reportNumber.ToString().Equals("NULL"))
                        {
                            var datatype = reportNumber.GetType();

                            try
                            {
                                reportNumber = reader.GetString(7);
                            }
                            catch 
                            { 
                                reportNumber = reader.GetDouble(7).ToString();
                            }
                        }
                        else
                        {
                            reportNumber = string.Empty;
                        }

                        writer.WritePropertyName("ReportNumber");
                        writer.WriteValue(reportNumber);


                        var iSBN = reader.GetValue(8);
                        if (!iSBN.ToString().Equals("NULL"))
                        {
                            try
                            {
                                iSBN = reader.GetString(8);
                            }
                            catch
                            {
                                var x = iSBN.GetType();
                                iSBN = reader.GetDouble(8).ToString();
                            }

                        }
                        else 
                        { 
                            iSBN = string.Empty;
                        }
                        writer.WritePropertyName("ISBN");
                        writer.WriteValue(iSBN);

                        var iSSN = reader.GetValue(9);
                        if (!iSSN.ToString().Equals("NULL"))
                        {
                            iSSN = reader.GetString(9);
                        }
                        else
                        {
                            iSSN = string.Empty;
                        }
                        writer.WritePropertyName("ISSN");
                        writer.WriteValue(iSSN);


                        var publicatorName = reader.GetString(10);
                        if (string.IsNullOrEmpty(publicatorName))
                        {
                            publicatorName = string.Empty;
                        }
                        writer.WritePropertyName("PublicatorName");
                        writer.WriteValue(publicatorName);

                        //Problem - den er null eller double

                        

                       
                        var year = reader.GetValue(11);
                        if(!year.ToString().Equals("NULL"))
                        {
                            year = reader.GetDouble(11).ToString();//.ToString();

                        }
                        else
                        {
                            year = string.Empty;
                        }
                        writer.WritePropertyName("Year");
                        writer.WriteValue(year);

                        /*
                        var year = reader.GetString(11);//.ToString();
                        if (string.IsNullOrEmpty(year))
                        {
                            year = string.Empty;
                        }
                        writer.WritePropertyName("Year");
                        writer.WriteValue(year);
                        */

                        var volume = reader.GetValue(12);
                        if (!volume.ToString().Equals("NULL"))
                        {
                            try
                            {
                                volume = reader.GetDouble(12).ToString();
                            }
                            catch
                            {
                                var type = volume.GetType();
                                if (type == typeof(string))
                                {
                                    volume = reader.GetString(12);
                                }

                                volume = reader.GetString(12);
                            }

                        }
                        else
                        {
                            volume = string.Empty;
                        }

                        writer.WritePropertyName("Volume");
                        writer.WriteValue(volume);
                        /*
                        var volume = reader.GetString(12);
                        if (string.IsNullOrEmpty(volume))
                        {
                            volume = string.Empty;
                        }
                        writer.WritePropertyName("Volume");
                        writer.WriteValue(volume);
                        */

                        var issue = reader.GetValue(13);

                        if (!issue.ToString().Equals("NULL"))
                        {
                            //issue = reader.GetString(13);
                            issue = issue.ToString();
                        }
                        else
                        {
                            issue = string.Empty;
                        }


                        /*

                        var issue = reader.GetString(13);
                        if (string.IsNullOrEmpty(issue))
                        {
                            issue = string.Empty;
                        }
                        */
                        writer.WritePropertyName("Issue");
                        writer.WriteValue(issue);

                        //var pagestart = reader.GetDouble(14).ToString();
                        
                        
                        var pagestart = reader.GetValue(14);

                        if (!pagestart.ToString().Equals("NULL"))
                        {
                            pagestart = reader.GetDouble(14).ToString();
                        }
                        else
                        {
                            pagestart = string.Empty;
                        }


                        /*
                        if (string.IsNullOrEmpty(pagestart))
                        {
                            pagestart = string.Empty;
                        }
                        */
                        writer.WritePropertyName("Pagestart");
                        writer.WriteValue(pagestart);

                        //var pageend = reader.GetDouble(14).ToString();
                        var pageend = reader.GetValue(15);
                        if (!pageend.ToString().Equals("NULL"))
                        {
                            pageend = reader.GetDouble(15).ToString();
                        }
                        else
                        {
                            pageend = string.Empty;
                        }
                        writer.WritePropertyName("Pageend");
                        writer.WriteValue(pageend);




                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }
        }

        private void ConvertFoodParamsBtnClick(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();


            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\FoodParameter\\FoodParametersAsJSON.txt";


            FoodParamsToJSON(excelPath, jsonPath);

            MessageBox.Show("Done !");
        }

        private void FoodParamsToJSON(string inputFile, string outputFile)
        {
            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                do
                {
                    while (reader.Read())
                    {
                        //We don't need an empty object
                        var sourceId = reader.GetDouble(0).ToString();
                        if (string.IsNullOrEmpty(sourceId)) break;

                        writer.WriteStartObject();
                        //Select Columns and values
                        writer.WritePropertyName("FoodId");
                        writer.WriteValue(sourceId);


                        var parameterId = reader.GetDouble(3).ToString();
                        if (string.IsNullOrEmpty(parameterId)) break;
                        writer.WritePropertyName("ParameterId");
                        writer.WriteValue(parameterId);


                        //Value:
                        var resVal = reader.GetValue(7);
                        if (!resVal.ToString().Equals("NULL"))
                        {
                            if (resVal.GetType() == typeof(string))
                            {
                                resVal = resVal.ToString();
                            }
                            else if (resVal.GetType() == typeof(double))
                            {
                                resVal = reader.GetDouble(7).ToString();
                            }
                            else if (resVal.GetType() != typeof(string) && resVal.GetType() != typeof(double))
                            {
                                resVal = string.Empty;
                            }
                        else
                        {
                            resVal = string.Empty;
                        }
                        writer.WritePropertyName("ResVal");
                        writer.WriteValue(resVal);
                        }



                        //Source:
                        var source = reader.GetValue(8);
                        if (!source.ToString().Equals("NULL"))
                        {
                            if (source.GetType() == typeof(string))
                            {
                                source = source.ToString();
                            }
                            else if (source.GetType() == typeof(double))    
                            {
                                source = reader.GetDouble(8).ToString();
                            }
                            else if (source.GetType() != typeof(string) && source.GetType() != typeof(double))
                            {
                                source = string.Empty;
                            }
                            else
                            {
                                source = string.Empty;
                            }
                        }
                        else
                        {
                            source= string.Empty;
                        }
                            writer.WritePropertyName("Sources");
                            writer.WriteValue(source);

                        //SourceFood:
                        var sourceFood = reader.GetValue(9);
                        if (!sourceFood.ToString().Equals("NULL"))
                        {
                            if (sourceFood.GetType() == typeof(string))
                            {
                                sourceFood = sourceFood.ToString();
                            }
                            else if (sourceFood.GetType() == typeof(double))
                            {
                                sourceFood = reader.GetDouble(9).ToString();
                            }
                            else if (sourceFood.GetType() != typeof(string) && sourceFood.GetType() != typeof(double))
                            {
                                sourceFood   = string.Empty;
                            }
                            else
                            {
                                sourceFood = string.Empty;
                            }
                        }
                        else
                        {
                            sourceFood = string.Empty;
                        }

                        writer.WritePropertyName("SourceFood");
                        writer.WriteValue(sourceFood);




                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }

        }

        private void ParametersToParamGroupsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();


            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\Parameter\\ParameterGroupsAsJSON.txt";


            ParametersToParametersGroupJSON(excelPath, jsonPath);

            MessageBox.Show("Done !");


        }

        private void ParametersToParametersGroupJSON(string inputFile, string outputFile)
        {

            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                List<string> list = new List<string>();


                do
                {
                    while (reader.Read())
                    {

                        var parameterGroupId = reader.GetDouble(7).ToString();
                        if (string.IsNullOrEmpty(parameterGroupId)) break;

                        if (list.Contains(parameterGroupId))
                        {
                            continue;
                        }

                        list.Add(parameterGroupId);

                        writer.WriteStartObject();
                        writer.WritePropertyName("Id");
                        writer.WriteValue(parameterGroupId);

                        var foodGroupNameDk = reader.GetString(8);
                        if (string.IsNullOrEmpty(foodGroupNameDk))
                        {
                            foodGroupNameDk = string.Empty;
                        }
                        writer.WritePropertyName("NameDk");
                        writer.WriteValue(foodGroupNameDk);

                        var foodGroupNameEng = reader.GetString(9);
                        if (string.IsNullOrEmpty(foodGroupNameEng))
                        {
                            foodGroupNameEng = string.Empty;
                        }
                        writer.WritePropertyName("NameEng");
                        writer.WriteValue(foodGroupNameEng);



                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }
        }

        private void foodToFoodGroupBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();

            //string jsonPath = "C:\\Users\\larsw\\Downloads\\output.txt";

            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\Food\\FoodGroupAsJSON.txt";


            FoodToFoodGroupAsJSON(excelPath, jsonPath);

            MessageBox.Show("Done !");

        }

        private void FoodToFoodGroupAsJSON(string inputFile, string outputFile)
        {
            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                List<string> list = new List<string>();


                do
                {
                    while (reader.Read())
                    {

                        var foodGroupId = reader.GetDouble(5).ToString();
                        if (string.IsNullOrEmpty(foodGroupId)) break;

                        if (list.Contains(foodGroupId))
                        {
                            continue;
                        }
                        
                        list.Add(foodGroupId);

                        writer.WriteStartObject();
                        writer.WritePropertyName("FoodGroupId");
                        writer.WriteValue(foodGroupId);

                        var foodGroupNameDk = reader.GetString(6);
                        if (string.IsNullOrEmpty(foodGroupNameDk))
                        {
                            foodGroupNameDk = string.Empty;
                        }
                        writer.WritePropertyName("NameDk");
                        writer.WriteValue(foodGroupNameDk);

                        var foodGroupNameEng = reader.GetString(7);
                        if (string.IsNullOrEmpty(foodGroupNameEng))
                        {
                            foodGroupNameEng = string.Empty;
                        }
                        writer.WritePropertyName("NameEng");
                        writer.WriteValue(foodGroupNameEng);



                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }



        }

        private void generateFoodSourceBtn_Click(object sender, EventArgs e)
        {
            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\Food\\FoodSourceAsJSON.txt";


            GenerateFoodSourceAsJSON(jsonPath);

            MessageBox.Show("Done !");

        }

        private void GenerateFoodSourceAsJSON(string jsonPath)
        {

            using (var outFile = File.CreateText(jsonPath))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                writer.WriteStartArray();
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();

                //Indlæs Fødevaredata:

                writer.WritePropertyName("Id");
                writer.WriteValue("1");

                writer.WritePropertyName("NameLong");
                writer.WriteValue("Fødevaredata (http://frida.fooddata.dk), version 4.2, Juni 2022. Fødevareinstituttet, Danmarks Tekniske Universitet");

                writer.WritePropertyName("NameShort");
                writer.WriteValue("Fødevaredata (http://frida.fooddata.dk), version 4.2, Juni 2022.");

                writer.WritePropertyName("NameUltraShort");
                writer.WriteValue("Fødevaredata, version 4.2, Juni 2022");

                writer.WritePropertyName("UserId");
                writer.WriteValue("");



                writer.WriteEndObject();


                writer.WriteEndArray();


            }
        }

        private void convertParametersToParameterUnitBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string excelPath = fil.FileName.ToString();

            //string jsonPath = "C:\\Users\\larsw\\Downloads\\output.txt";

            string jsonPath = "C:\\Users\\larsw\\GnuflingSoloutions\\FoodDatasets\\Parameter\\ParametersAsParameterUnit.txt";

            ParametersToParametersUnitJSON(excelPath, jsonPath);

            MessageBox.Show("Done !");

        }

        private void ParametersToParametersUnitJSON(string inputFile, string outputFile)
        {
            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))

            //new JsonTextWriter(outFile))

            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                //writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                List<string> list = new List<string>();
                int id = 1;
                do
                {
                    while (reader.Read())
                    {
                        //We don't need an empty object
                        var unitString = reader.GetString(2);
                        if (string.IsNullOrEmpty(unitString) ||list.Contains(unitString))
                        {
                            continue;
                        }

                        list.Add(unitString);

                        writer.WriteStartObject();
                        //Select Columns and values
                        writer.WritePropertyName("UnitString");
                        writer.WriteValue(unitString);

                        writer.WritePropertyName("Id");
                        writer.WriteValue(id.ToString());
                        id++;

                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }
        }
    }




}   


