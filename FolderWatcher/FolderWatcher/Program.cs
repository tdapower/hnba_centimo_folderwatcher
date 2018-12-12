//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using System.Data.OracleClient;
//using System.Data;

//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using System.Threading;


//namespace FolderWatcher
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Clear();
//            Console.WriteLine("Do not close this console .... ");





//            Thread thread1 = new Thread(new ThreadStart(startNewBusiness));
//            thread1.Start();

//            Thread thread2 = new Thread(new ThreadStart(startEndorsement));
//            thread2.Start();

//            Thread thread3 = new Thread(new ThreadStart(startRenewal));
//            thread3.Start();

//            Thread thread4 = new Thread(new ThreadStart(startCancellation));
//            thread4.Start();











//            Console.ReadLine();
//        }



//        private static void startNewBusiness()
//        {

//            FileSystemWatcher NewBusinessWatcher = new FileSystemWatcher();
//            NewBusinessWatcher.Path = @"E:\HNBGI\SCN_DOCS\NEW\";
//            NewBusinessWatcher.IncludeSubdirectories = true;
//            NewBusinessWatcher.Created += new FileSystemEventHandler(ProcessNewBusinessFolder);
//            NewBusinessWatcher.EnableRaisingEvents = true;

//        }
//        private static void startEndorsement()
//        {

//            FileSystemWatcher EndorsementWatcher = new FileSystemWatcher();
//            EndorsementWatcher.Path = @"E:\HNBGI\SCN_DOCS\ENDORSEMENT\";
//            EndorsementWatcher.IncludeSubdirectories = true;
//            EndorsementWatcher.Created += new FileSystemEventHandler(ProcessEndorsementFolder);
//            EndorsementWatcher.EnableRaisingEvents = true;

//        }
//        private static void startRenewal()
//        {

//            FileSystemWatcher RenewalWatcher = new FileSystemWatcher();
//            RenewalWatcher.Path = @"E:\HNBGI\SCN_DOCS\RENEWAL\";
//            RenewalWatcher.IncludeSubdirectories = true;
//            RenewalWatcher.Created += new FileSystemEventHandler(ProcessRenewalFolder);
//            RenewalWatcher.EnableRaisingEvents = true;


//        }
//        private static void startCancellation()
//        {
//            FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
//            CancellationWatcher.Path = @"E:\HNBGI\SCN_DOCS\CANCELLATION\";
//            CancellationWatcher.IncludeSubdirectories = true;
//            CancellationWatcher.Created += new FileSystemEventHandler(ProcessCancellationFolder);
//            CancellationWatcher.EnableRaisingEvents = true;



//        }

//        //  private static void ProcessNewBusinessFolder(object sender, FileSystemEventArgs e)
//        private static void ProcessNewBusinessFolder(object sender, FileSystemEventArgs e)
//        {

//            Console.WriteLine("New Business Received.... ");



//            DirectoryInfo d = new DirectoryInfo(@"E:\HNBGI\SCN_DOCS\NEW\");
//            DirectoryInfo dest = new DirectoryInfo(@"E:\HNBGI\QUEUED_SCN_DOCS\NEW\");


//            if (!d.Exists)
//            {
//                return;
//            }

//            FileInfo[] Files = d.GetFiles("*.pdf");
//            string quotationNo = "";
//            string branchCode = "";
//            foreach (FileInfo file in Files)
//            {
//                quotationNo = file.Name;

//                DirectoryInfo newDir = null;

//                if (!Directory.Exists(dest.FullName + quotationNo.ToUpper()))
//                {
//                    System.IO.Directory.CreateDirectory(dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
//                }



//                if (quotationNo.Length > 10)
//                {
//                    branchCode = quotationNo.Substring(2, 3);
//                }

//                //Wait untill file process finish
//                //Thread.Sleep(1000);

//                Console.WriteLine(quotationNo + " -     " + branchCode);
//                try
//                {
//                    if (IsFileLocked(file.FullName))
//                    {

//                    }
//                    File.Move(file.FullName, dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());
//                    InsertNewBusiness(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), branchCode, "N");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.ToString());
//                }
//            }



//            // Force a garbage collection to occur for this demo.
//            //GC.Collect();
//        }
//        private static void ProcessEndorsementFolder(object sender, FileSystemEventArgs e)
//        {

//            Console.WriteLine("Endorsement Received.... ");

//            DirectoryInfo d = new DirectoryInfo(@"E:\HNBGI\SCN_DOCS\ENDORSEMENT\");
//            DirectoryInfo dest = new DirectoryInfo(@"E:\HNBGI\QUEUED_SCN_DOCS\ENDORSEMENT\");



//            if (!d.Exists)
//            {
//                return;
//            }


//            FileInfo[] Files = d.GetFiles("*.pdf");
//            string jobNo = "";
//            string branchCode = "";
//            foreach (FileInfo file in Files)
//            {
//                jobNo = file.Name;

//                DirectoryInfo newDir = null;

//                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
//                {

//                    System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
//                }

//                //Wait untill file process finish
//                Thread.Sleep(1000);


//                Console.WriteLine(jobNo + " -     " + branchCode);
//                try
//                {

//                    File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());
//                    UpdateEndorsement(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.ToString());
//                }
//            }



//            // Force a garbage collection to occur for this demo.
//            //GC.Collect();
//        }

//        private static void ProcessRenewalFolder(object sender, FileSystemEventArgs e)
//        {

//            Console.WriteLine("Renewal Received.... ");


//            DirectoryInfo d = new DirectoryInfo(@"E:\HNBGI\SCN_DOCS\RENEWAL\");
//            DirectoryInfo dest = new DirectoryInfo(@"E:\HNBGI\QUEUED_SCN_DOCS\RENEWAL\");



//            if (!d.Exists)
//            {
//                return;
//            }


//            FileInfo[] Files = d.GetFiles("*.pdf");
//            string jobNo = "";
//            string branchCode = "";
//            foreach (FileInfo file in Files)
//            {
//                jobNo = file.Name;

//                DirectoryInfo newDir = null;

//                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
//                {

//                    System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

//                }

//                //Wait untill file process finish
//                Thread.Sleep(1000);

//                Console.WriteLine(jobNo + " -     " + branchCode);
//                try
//                {

//                    File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());
//                    UpdateRenewal(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());


//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.ToString());
//                }
//            }


//            // Force a garbage collection to occur for this demo.
//            //GC.Collect();
//        }

//        private static void ProcessCancellationFolder(object sender, FileSystemEventArgs e)
//        {


//            Console.WriteLine("Cancellation Received.... ");

//            DirectoryInfo d = new DirectoryInfo(@"E:\HNBGI\SCN_DOCS\CANCELLATION\");
//            DirectoryInfo dest = new DirectoryInfo(@"E:\HNBGI\QUEUED_SCN_DOCS\CANCELLATION\");



//            if (!d.Exists)
//            {
//                return;
//            }


//            FileInfo[] Files = d.GetFiles("*.pdf");
//            string jobNo = "";
//            string branchCode = "";
//            foreach (FileInfo file in Files)
//            {
//                jobNo = file.Name;

//                DirectoryInfo newDir = null;

//                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
//                {
//                    System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
//                }



//                string outputFileWithPath = "";
//                outputFileWithPath = dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper();

//                //Wait untill file process finish
//                Thread.Sleep(1000);

//                Console.WriteLine(jobNo + " -     " + branchCode);
//                try
//                {

//                    if (File.Exists(outputFileWithPath))
//                    {
//                        string temPathForMerge = "";
//                        temPathForMerge = dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\TEMP_" + file.Name.ToUpper();
//                        //To merge PDFs if there are more than multiple PDFs scanned from different branches
//                        MergePDFs(temPathForMerge, file.FullName, outputFileWithPath);

//                        string bkpDoc = "";
//                        bkpDoc = outputFileWithPath + ".bak";
//                        File.Replace(temPathForMerge, outputFileWithPath, bkpDoc, false);
//                        File.Delete(file.FullName);

//                    }
//                    else
//                    {
//                        File.Move(file.FullName, outputFileWithPath);
//                    }


//                    UpdateCancellation(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.ToString());
//                }
//            }




//            // Force a garbage collection to occur for this demo.
//            //GC.Collect();
//        }





//        private static void MergePDFs(string outPutFilePath, params string[] filesPath)
//        {
//            List<PdfReader> readerList = new List<PdfReader>();
//            foreach (string filePath in filesPath)
//            {
//                PdfReader pdfReader = new PdfReader(filePath);
//                readerList.Add(pdfReader);
//            }

//            //Define a new output document and its size, type
//            Document document = new Document(PageSize.A4, 0, 0, 0, 0);
//            //Create blank output pdf file and get the stream to write on it.
//            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outPutFilePath, FileMode.Create));
//            document.Open();

//            foreach (PdfReader reader in readerList)
//            {
//                for (int i = 1; i <= reader.NumberOfPages; i++)
//                {
//                    PdfImportedPage page = writer.GetImportedPage(reader, i);
//                    document.Add(iTextSharp.text.Image.GetInstance(page));
//                }
//            }
//            document.Close();
//            writer.Close();
//        }


//        public static void InsertNewBusiness(string quotationNo, string branchCode, string JobType)
//        {
//            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);
//            OracleCommand cmd = new OracleCommand("INSERT_MNBQ_PROPOSAL_UPLOAD", con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            cmd.Parameters.Add(new OracleParameter("V_QUOTATION_NO", OracleType.VarChar));
//            cmd.Parameters["V_QUOTATION_NO"].Value = quotationNo;

//            cmd.Parameters.Add(new OracleParameter("V_ENTERED_USER_BRANCH_CODE", OracleType.VarChar));
//            cmd.Parameters["V_ENTERED_USER_BRANCH_CODE"].Value = branchCode;

//            try
//            {
//                con.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (OracleException err)
//            {
//                // Replace the error with something less specific.
//                // You could also log the error now.

//                Console.WriteLine(err.ToString());
//                throw new ApplicationException("Data error.");
//            }
//            finally
//            {
//                con.Close();
//            }
//        }
//        public static void UpdateEndorsement(string jobNo)
//        {
//            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);
//            OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_ENDORSEMENT", con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
//            cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


//            try
//            {
//                con.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (OracleException err)
//            {
//                // Replace the error with something less specific.
//                // You could also log the error now.

//                Console.WriteLine(err.ToString());
//                throw new ApplicationException("Data error.");
//            }
//            finally
//            {
//                con.Close();
//            }
//        }

//        public static void UpdateRenewal(string jobNo)
//        {
//            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);
//            OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_RENEWAL", con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
//            cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


//            try
//            {
//                con.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (OracleException err)
//            {
//                // Replace the error with something less specific.
//                // You could also log the error now.

//                Console.WriteLine(err.ToString());
//                throw new ApplicationException("Data error.");
//            }
//            finally
//            {
//                con.Close();
//            }
//        }


//        public static void UpdateCancellation(string jobNo)
//        {
//            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);
//            OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_CANCELLATION", con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
//            cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


//            try
//            {
//                con.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (OracleException err)
//            {
//                // Replace the error with something less specific.
//                // You could also log the error now.

//                Console.WriteLine(err.ToString());
//                throw new ApplicationException("Data error.");
//            }
//            finally
//            {
//                con.Close();
//            }
//        }

//        public bool IsFileLocked(string filePath)
//        {
//            try
//            {
//                using (File.Open(filePath, FileMode.Open)) { }
//            }
//            catch (IOException e)
//            {
//                var errorCode = Marshal.GetHRForException(e) & ((1 << 16) - 1);

//                return errorCode == 32 || errorCode == 33;
//            }

//            return false;
//        }
//    }
//}
