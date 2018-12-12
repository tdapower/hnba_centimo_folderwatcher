using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.OracleClient;
using System.Data;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading;


namespace FolderWatcher
{
    class FileProcessor
    {
        private static Timer tmrGivenUpJobProcessor;
        static void Main(string[] args)
        {

            if (SingleInstance.SingleApplication.Run() == false)
            {
                return;
            }

            Console.Clear();
            Console.WriteLine("Do not close this console .... ");


            Thread thread1 = new Thread(new ThreadStart(startNewBusiness));
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(startEndorsement));
            thread2.Start();

            Thread thread3 = new Thread(new ThreadStart(startRenewal));
            thread3.Start();

            Thread thread4 = new Thread(new ThreadStart(startCancellation));
            thread4.Start();

            Thread thread5 = new Thread(new ThreadStart(startFastTrackNewBusiness));
            thread5.Start();



            Thread thread1_2 = new Thread(new ThreadStart(startNewBusiness2));
            thread1_2.Start();

            Thread thread2_2 = new Thread(new ThreadStart(startEndorsement2));
            thread2_2.Start();

            Thread thread3_2 = new Thread(new ThreadStart(startRenewal2));
            thread3_2.Start();

            Thread thread4_2 = new Thread(new ThreadStart(startCancellation2));
            thread4_2.Start();

            Thread thread5_2 = new Thread(new ThreadStart(startFastTrackNewBusiness2));
            thread5_2.Start();




            Thread thread1_3 = new Thread(new ThreadStart(startNewBusiness3));
            thread1_3.Start();

            Thread thread2_3 = new Thread(new ThreadStart(startEndorsement3));
            thread2_3.Start();

            Thread thread3_3 = new Thread(new ThreadStart(startRenewal3));
            thread3_3.Start();

            Thread thread4_3 = new Thread(new ThreadStart(startCancellation3));
            thread4_3.Start();

            Thread thread5_3 = new Thread(new ThreadStart(startFastTrackNewBusiness3));
            thread5_3.Start();



            Thread thread1_4 = new Thread(new ThreadStart(startNewBusiness4));
            thread1_4.Start();

            Thread thread2_4 = new Thread(new ThreadStart(startEndorsement4));
            thread2_4.Start();

            Thread thread3_4 = new Thread(new ThreadStart(startRenewal4));
            thread3_4.Start();

            Thread thread4_4 = new Thread(new ThreadStart(startCancellation4));
            thread4_4.Start();

            Thread thread5_4 = new Thread(new ThreadStart(startFastTrackNewBusiness4));
            thread5_4.Start();



            InitTimer();

            Console.ReadLine();
        }



        private static void startNewBusiness()
        {
            try
            {
                FileSystemWatcher NewBusinessWatcher = new FileSystemWatcher();
                NewBusinessWatcher.Path = @Properties.Settings.Default.PathNewBusiness;
                NewBusinessWatcher.IncludeSubdirectories = true;
                NewBusinessWatcher.Created += new FileSystemEventHandler(ProcessNewBusinessFolder);
                NewBusinessWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startNewBusiness");
            }
        }

        private static void startFastTrackNewBusiness()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathNewBusinessFST1;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessPathNewBusinessFST);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startFastTrackNewBusiness");
            }
        }



        private static void startEndorsement()
        {
            try
            {
                FileSystemWatcher EndorsementWatcher = new FileSystemWatcher();
                EndorsementWatcher.Path = @Properties.Settings.Default.PathEndorsement;
                EndorsementWatcher.IncludeSubdirectories = true;
                EndorsementWatcher.Created += new FileSystemEventHandler(ProcessEndorsementFolder);
                EndorsementWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startEndorsement");
            }
        }
        private static void startRenewal()
        {
            try
            {
                FileSystemWatcher RenewalWatcher = new FileSystemWatcher();
                RenewalWatcher.Path = @Properties.Settings.Default.PathRenewal;
                RenewalWatcher.IncludeSubdirectories = true;
                RenewalWatcher.Created += new FileSystemEventHandler(ProcessRenewalFolder);
                RenewalWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startRenewal");
            }
        }
        private static void startCancellation()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathCancellation;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessCancellationFolder);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startCancellation");
            }
        }

      

        private static void startNewBusiness2()
        {
            try
            {
                FileSystemWatcher NewBusinessWatcher = new FileSystemWatcher();
                NewBusinessWatcher.Path = @Properties.Settings.Default.PathNewBusiness2;
                NewBusinessWatcher.IncludeSubdirectories = true;
                NewBusinessWatcher.Created += new FileSystemEventHandler(ProcessNewBusinessFolder2);
                NewBusinessWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startNewBusiness2");
            }
        }

        private static void startFastTrackNewBusiness2()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathNewBusinessFST2;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessPathNewBusinessFST2);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startFastTrackNewBusiness2");
            }
        }

        private static void startEndorsement2()
        {
            try
            {
                FileSystemWatcher EndorsementWatcher = new FileSystemWatcher();
                EndorsementWatcher.Path = @Properties.Settings.Default.PathEndorsement2;
                EndorsementWatcher.IncludeSubdirectories = true;
                EndorsementWatcher.Created += new FileSystemEventHandler(ProcessEndorsementFolder2);
                EndorsementWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startEndorsement2");
            }
        }
        private static void startRenewal2()
        {
            try
            {
                FileSystemWatcher RenewalWatcher = new FileSystemWatcher();
                RenewalWatcher.Path = @Properties.Settings.Default.PathRenewal2;
                RenewalWatcher.IncludeSubdirectories = true;
                RenewalWatcher.Created += new FileSystemEventHandler(ProcessRenewalFolder2);
                RenewalWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startRenewal2");
            }
        }
        private static void startCancellation2()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathCancellation2;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessCancellationFolder2);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startCancellation2");
            }
        }



        private static void startNewBusiness3()
        {
            try
            {
                FileSystemWatcher NewBusinessWatcher = new FileSystemWatcher();
                NewBusinessWatcher.Path = @Properties.Settings.Default.PathNewBusiness3;
                NewBusinessWatcher.IncludeSubdirectories = true;
                NewBusinessWatcher.Created += new FileSystemEventHandler(ProcessNewBusinessFolder3);
                NewBusinessWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startNewBusiness3");
            }
        }

        private static void startFastTrackNewBusiness3()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathNewBusinessFST3;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessPathNewBusinessFST3);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startFastTrackNewBusiness2");
            }
        }

        private static void startEndorsement3()
        {
            try
            {
                FileSystemWatcher EndorsementWatcher = new FileSystemWatcher();
                EndorsementWatcher.Path = @Properties.Settings.Default.PathEndorsement3;
                EndorsementWatcher.IncludeSubdirectories = true;
                EndorsementWatcher.Created += new FileSystemEventHandler(ProcessEndorsementFolder3);
                EndorsementWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startEndorsement3");
            }
        }
        private static void startRenewal3()
        {
            try
            {
                FileSystemWatcher RenewalWatcher = new FileSystemWatcher();
                RenewalWatcher.Path = @Properties.Settings.Default.PathRenewal3;
                RenewalWatcher.IncludeSubdirectories = true;
                RenewalWatcher.Created += new FileSystemEventHandler(ProcessRenewalFolder3);
                RenewalWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startRenewal3");
            }
        }
        private static void startCancellation3()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathCancellation3;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessCancellationFolder3);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startCancellation3");
            }
        }


        private static void startNewBusiness4()
        {
            try
            {
                FileSystemWatcher NewBusinessWatcher = new FileSystemWatcher();
                NewBusinessWatcher.Path = @Properties.Settings.Default.PathNewBusiness4;
                NewBusinessWatcher.IncludeSubdirectories = true;
                NewBusinessWatcher.Created += new FileSystemEventHandler(ProcessNewBusinessFolder4);
                NewBusinessWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startNewBusiness4");
            }
        }
        private static void startFastTrackNewBusiness4()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathNewBusinessFST4;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessPathNewBusinessFST4);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startFastTrackNewBusiness2");
            }
        }

        private static void startEndorsement4()
        {
            try
            {
                FileSystemWatcher EndorsementWatcher = new FileSystemWatcher();
                EndorsementWatcher.Path = @Properties.Settings.Default.PathEndorsement4;
                EndorsementWatcher.IncludeSubdirectories = true;
                EndorsementWatcher.Created += new FileSystemEventHandler(ProcessEndorsementFolder4);
                EndorsementWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startEndorsement4");
            }
        }
        private static void startRenewal4()
        {
            try
            {
                FileSystemWatcher RenewalWatcher = new FileSystemWatcher();
                RenewalWatcher.Path = @Properties.Settings.Default.PathRenewal4;
                RenewalWatcher.IncludeSubdirectories = true;
                RenewalWatcher.Created += new FileSystemEventHandler(ProcessRenewalFolder4);
                RenewalWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startRenewal4");
            }
        }
        private static void startCancellation4()
        {
            try
            {
                FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
                CancellationWatcher.Path = @Properties.Settings.Default.PathCancellation4;
                CancellationWatcher.IncludeSubdirectories = true;
                CancellationWatcher.Created += new FileSystemEventHandler(ProcessCancellationFolder4);
                CancellationWatcher.EnableRaisingEvents = true;
            }
            catch (Exception)
            {
                Console.WriteLine("error in startCancellation4");
            }
        }


        public static void InitTimer()
        {
            tmrGivenUpJobProcessor = new Timer(processGivenUpJobs, null, 0, 300000);
        }



        public static void processGivenUpJobs(Object o)
        {
            try
            {
                OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);
                OracleDataReader dr;

                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                String selectQuery = "";

                selectQuery = " SELECT T.SEQ_ID,T.JOB_TYPE,T.FULL_PATH FROM MNBQ_WF_GIVENUP_JOBS T ORDER BY T.SYS_DATE ";




                cmd.CommandText = selectQuery;

                dr = cmd.ExecuteReader();



                while (dr.Read())
                {

                    string jobType = "";
                    jobType = dr[1].ToString();

                    string filePath = dr[2].ToString();
                    deleteGivenUpJobRecors(dr[0].ToString());

                    if (jobType == "NEW")
                    {
                        ThreadStart starter = delegate { ProcessNewBusinessFolderForGivenUpJobs(filePath); };
                        Thread threadNew = new Thread(starter);
                        threadNew.Start();

                    }
                    else if (jobType == "RENEWAL")
                    {
                        ThreadStart starter = delegate { ProcessRenewalFolderForGivenUpJobs(filePath); };
                        Thread threadRENEWAL = new Thread(starter);
                        threadRENEWAL.Start();
                    }
                    else if (jobType == "ENDORSEMENT")
                    {

                        ThreadStart starter = delegate { ProcessEndorsementFolderForGivenUpJobs(filePath); };
                        Thread threadENDORSEMENT = new Thread(starter);
                        threadENDORSEMENT.Start();
                    }
                    else if (jobType == "CANCELLATION")
                    {
                        ThreadStart starter = delegate { ProcessCancellationFolderForGivenUpJobs(filePath); };
                        Thread threadCANCELLATION = new Thread(starter);
                        threadCANCELLATION.Start();
                    }
                }

                dr.Close();
                dr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
            catch (Exception)
            {

            }


        }

        private static void deleteGivenUpJobRecors(string seqId)
        {
            try
            {
                OracleConnection conProcess = new OracleConnection(Properties.Settings.Default.DBConString);
                conProcess.Open();
                OracleCommand spProcess = null;

                string strQuery = "";

                strQuery = "DELETE FROM MNBQ_WF_GIVENUP_JOBS WHERE   SEQ_ID=" + seqId;

                spProcess = new OracleCommand(strQuery, conProcess);

                spProcess.ExecuteNonQuery();
                conProcess.Close();
                conProcess.Dispose();
            }
            catch (Exception ex)
            {

            }

        }






        private static void ProcessNewBusinessFolder(object sender, FileSystemEventArgs e)
        {
            string quotationNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            string SystemName = "";

            try
            {

                Console.WriteLine("New Business Received.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));


                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusiness);

                if (!file.Exists)
                {
                    return;
                }
                quotationNo = file.Name;

                if (!validateQuotationNoFromDB(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;
                }

                if (isValidJob)
                {
                    if (!validateStatusOfJob(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + quotationNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }

                if (quotationNo.Length > 10)
                {
                    branchCode = quotationNo.Substring(2, 3);


                    if (quotationNo[5] == 'T')
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TAKAFUL;
                    }
                    else
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TCS;
                    }
                }

                Console.WriteLine(quotationNo + " -     " + branchCode);

                if (WaitForFile(quotationNo, "NEW", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        InsertNewBusiness1(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), branchCode, "N", SystemName);

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(quotationNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");

                    }
                    else
                    {

                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(quotationNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", quotationNo, ex.ToString())));


                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
            }
        }

        private static void ProcessNewBusinessFolder2(object sender, FileSystemEventArgs e)
        {
            string quotationNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            string SystemName = "";

            try
            {

                Console.WriteLine("New Business Received for Location 2.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusiness);

                if (!file.Exists)
                {
                    return;
                }
                quotationNo = file.Name;

                if (!validateQuotationNoFromDB(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;
                }

                if (isValidJob)
                {
                    if (!validateStatusOfJob(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + quotationNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }

                if (quotationNo.Length > 10)
                {
                    branchCode = quotationNo.Substring(2, 3);


                    if (quotationNo[5] == 'T')
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TAKAFUL;
                    }
                    else
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TCS;
                    }
                }

                Console.WriteLine(quotationNo + " -     " + branchCode);

                if (WaitForFileLong(quotationNo, "NEW", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        InsertNewBusiness2(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), branchCode, "N", SystemName);

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(quotationNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {

                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(quotationNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", quotationNo, ex.ToString())));


                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
            }
        }

        private static void ProcessNewBusinessFolder3(object sender, FileSystemEventArgs e)
        {
            string quotationNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            string SystemName = "";

            try
            {

                Console.WriteLine("New Business Received for Location 3.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusiness);

                if (!file.Exists)
                {
                    return;
                }
                quotationNo = file.Name;

                if (!validateQuotationNoFromDB(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;
                }

                if (isValidJob)
                {
                    if (!validateStatusOfJob(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + quotationNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }

                if (quotationNo.Length > 10)
                {
                    branchCode = quotationNo.Substring(2, 3);


                    if (quotationNo[5] == 'T')
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TAKAFUL;
                    }
                    else
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TCS;
                    }
                }

                Console.WriteLine(quotationNo + " -     " + branchCode);

                if (WaitForFileLonger(quotationNo, "NEW", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        InsertNewBusiness3(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), branchCode, "N", SystemName);

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(quotationNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {

                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(quotationNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", quotationNo, ex.ToString())));


                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
            }
        }

        private static void ProcessNewBusinessFolder4(object sender, FileSystemEventArgs e)
        {
            string quotationNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            string SystemName = "";

            try
            {

                Console.WriteLine("New Business Received for Location 4.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusiness);

                if (!file.Exists)
                {
                    return;
                }
                quotationNo = file.Name;

                if (!validateQuotationNoFromDB(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;
                }

                if (isValidJob)
                {
                    if (!validateStatusOfJob(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + quotationNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }

                if (quotationNo.Length > 10)
                {
                    branchCode = quotationNo.Substring(2, 3);


                    if (quotationNo[5] == 'T')
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TAKAFUL;
                    }
                    else
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TCS;
                    }
                }

                Console.WriteLine(quotationNo + " -     " + branchCode);

                if (WaitForFileLonger(quotationNo, "NEW", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        InsertNewBusiness4(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), branchCode, "N", SystemName);

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(quotationNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {

                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(quotationNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", quotationNo, ex.ToString())));


                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
            }
        }

        private static void ProcessNewBusinessFolderForGivenUpJobs(String filePath)
        {
            string quotationNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(filePath);
            string SystemName = "";

            try
            {

                Console.WriteLine("New Business Received from Given Ups.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusiness);

                if (!file.Exists)
                {
                    return;
                }
                quotationNo = file.Name;

                if (!validateQuotationNoFromDB(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;
                }

                if (isValidJob)
                {
                    if (!validateStatusOfJob(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusiness);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + quotationNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }

                if (quotationNo.Length > 10)
                {
                    branchCode = quotationNo.Substring(2, 3);


                    if (quotationNo[5] == 'T')
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TAKAFUL;
                    }
                    else
                    {
                        SystemName = Properties.Settings.Default.SYSTEM_NAME_TCS;
                    }
                }

                Console.WriteLine(quotationNo + " -     " + branchCode);

                if (WaitForFileForGivenUpJobs(quotationNo, "NEW", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        InsertNewBusiness4(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), branchCode, "N", SystemName);

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(quotationNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {

                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(quotationNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", quotationNo, ex.ToString())));


                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(quotationNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEW", unknownType);
            }
        }
















        private static void ProcessEndorsementFolder(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("Endorsement Received.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedEndorsement);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFile(jobNo, "ENDORSEMENT", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateEndorsement1(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());


                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");

                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
            }
        }

        private static void ProcessEndorsementFolder2(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("Endorsement Received for Location 2.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedEndorsement);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLong(jobNo, "ENDORSEMENT", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateEndorsement2(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
            }
        }
        private static void ProcessEndorsementFolder3(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("Endorsement Received for Location 3.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedEndorsement);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "ENDORSEMENT", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateEndorsement3(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
            }
        }
        private static void ProcessEndorsementFolder4(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("Endorsement Received for Location 4.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedEndorsement);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "ENDORSEMENT", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateEndorsement4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
            }
        }

        private static void ProcessEndorsementFolderForGivenUpJobs(String filePath)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(filePath);

            try
            {

                Console.WriteLine("Endorsement Received from Given Ups.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedEndorsement);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownEndorsement);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileForGivenUpJobs(jobNo, "ENDORSEMENT", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateEndorsement4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "ENDORSEMENT", unknownType);
            }
        }


        private static void ProcessRenewalFolder(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {


                Console.WriteLine("Renewal Received.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));


                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedRenewal);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");


                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }

                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFile(jobNo, "RENEWAL", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateRenewal1(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
                    }

                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
            }

        }

        private static void ProcessRenewalFolder2(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {


                Console.WriteLine("Renewal Received for Location 2.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));


                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedRenewal);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");


                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }

                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLong(jobNo, "RENEWAL", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateRenewal2(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
                    }

                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
            }

        }
        private static void ProcessRenewalFolder3(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {


                Console.WriteLine("Renewal Received for Location 3.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));


                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedRenewal);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");


                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }

                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "RENEWAL", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateRenewal3(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
                    }

                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
            }

        }

        private static void ProcessRenewalFolder4(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {


                Console.WriteLine("Renewal Received for Location 4.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));


                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedRenewal);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");


                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }

                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "RENEWAL", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateRenewal4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
                    }

                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
            }

        }

        private static void ProcessRenewalFolderForGivenUpJobs(String filePath)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;
            FileInfo file = new FileInfo(filePath);
            try
            {


                Console.WriteLine("Renewal Received from Given Ups.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));


                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedRenewal);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownRenewal);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");


                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }

                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileForGivenUpJobs(jobNo, "RENEWAL", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateRenewal4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
                    }

                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "RENEWAL", unknownType);
            }

        }

        private static void ProcessCancellationFolder(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";

            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {

                Console.WriteLine("Cancellation Received.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedCancellation);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {

                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }

                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFile(jobNo, "CANCELLATION", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateCancellation1(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
            }
        }

        private static void ProcessCancellationFolder2(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";

            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {

                Console.WriteLine("Cancellation Received for Location 2.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedCancellation);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {

                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }

                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLong(jobNo, "CANCELLATION", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateCancellation2(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
            }
        }

        private static void ProcessCancellationFolder3(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";

            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {

                Console.WriteLine("Cancellation Received for Location 3.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedCancellation);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {

                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }

                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "CANCELLATION", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateCancellation3(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
            }
        }


        private static void ProcessCancellationFolder4(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";

            bool isValidJob = true;
            FileInfo file = new FileInfo(e.FullPath);
            try
            {

                Console.WriteLine("Cancellation Received for Location 4.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedCancellation);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {

                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }

                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "CANCELLATION", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateCancellation4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
            }
        }

        private static void ProcessCancellationFolderForGivenUpJobs(String filePath)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";

            bool isValidJob = true;
            FileInfo file = new FileInfo(filePath);
            try
            {

                Console.WriteLine("Cancellation Received from Given Ups.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedCancellation);

                if (!file.Exists)
                {
                    return;
                }

                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }

                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {

                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);
                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }

                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileForGivenUpJobs(jobNo, "CANCELLATION", file.FullName))
                {

                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateCancellation4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {
                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

                //unknownType = Properties.Settings.Default.UnknownFileError;
                //UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
            }
        }



        private static void ProcessPathNewBusinessFST(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("New Business FST.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusinessFST);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFile(jobNo, "NEWFST", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateNewBusinessFST1(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());


                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");

                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

            }
        }

        private static void ProcessPathNewBusinessFST2(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("New Business FST for Location 2.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusinessFST);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLong(jobNo, "NEWFST", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateNewBusinessFST2(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

            }
        }
        private static void ProcessPathNewBusinessFST3(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("New Business FST for Location 3.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusinessFST);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "NEWFST", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateNewBusinessFST3(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

            }
        }
        private static void ProcessPathNewBusinessFST4(object sender, FileSystemEventArgs e)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(e.FullPath);

            try
            {

                Console.WriteLine("New Business FST for Location 4.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusinessFST);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileLonger(jobNo, "NEWFST", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateNewBusinessFST4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

            }
        }

        private static void ProcessNewBusinessFSTForGivenUpJobs(String filePath)
        {
            string jobNo = "";
            string branchCode = "";
            string unknownType = "";
            bool isValidJob = true;

            FileInfo file = new FileInfo(filePath);

            try
            {

                Console.WriteLine("New Business FST from Given Ups.... ");
                DateTime inTime = DateTime.Now;
                Console.Write(inTime.ToString("HH:mm:ss tt  "));

                DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedNewBusinessFST);

                if (!file.Exists)
                {
                    return;
                }


                jobNo = file.Name;

                if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                {
                    isValidJob = false;
                    dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                    unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

                }
                if (isValidJob)
                {
                    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST"))
                    {
                        isValidJob = false;
                        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownNewBusinessFST);
                        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
                    }
                }
                string currentDate = "";
                currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

                if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
                {
                    if (isValidJob)
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(dest.FullName + currentDate);

                    }
                }


                if (jobNo.Length > 10)
                {
                    branchCode = jobNo.Substring(2, 3);
                }
                Console.WriteLine(jobNo + " -     " + branchCode);

                if (WaitForFileForGivenUpJobs(jobNo, "NEWFST", file.FullName))
                {
                    if (isValidJob)
                    {
                        File.Move(file.FullName, dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper());

                        UpdateNewBusinessFST4(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());

                        TimeSpan difference = DateTime.Now.Subtract(inTime);
                        Console.WriteLine(jobNo + " job Completed in.... " + difference.TotalSeconds + " Seconds");
                    }
                    else
                    {


                        File.Move(file.FullName, dest.FullName + currentDate + "\\" + file.Name.ToUpper());

                        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "NEWFST", unknownType);
                    }
                }
                else
                {

                    Console.WriteLine(jobNo + " has given up");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

            }
        }

        private static void MergePDFs(string outPutFilePath, params string[] filesPath)
        {
            List<PdfReader> readerList = new List<PdfReader>();
            foreach (string filePath in filesPath)
            {
                PdfReader pdfReader = new PdfReader(filePath);
                readerList.Add(pdfReader);
            }

            //Define a new output document and its size, type
            Document document = new Document(PageSize.A4, 0, 0, 0, 0);
            //Create blank output pdf file and get the stream to write on it.
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outPutFilePath, FileMode.Create));
            document.Open();

            foreach (PdfReader reader in readerList)
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    PdfImportedPage page = writer.GetImportedPage(reader, i);
                    document.Add(iTextSharp.text.Image.GetInstance(page));
                }
            }
            document.Close();
            writer.Close();
        }


        public static void InsertNewBusiness1(string quotationNo, string branchCode, string JobType, string SystemName)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("INSERT_MNBQ_PROPOSAL_UPLOAD_1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_QUOTATION_NO", OracleType.VarChar));
                cmd.Parameters["V_QUOTATION_NO"].Value = quotationNo;

                cmd.Parameters.Add(new OracleParameter("V_ENTERED_USER_BRANCH_CODE", OracleType.VarChar));
                cmd.Parameters["V_ENTERED_USER_BRANCH_CODE"].Value = branchCode;

                cmd.Parameters.Add(new OracleParameter("V_SYSTEM_NAME", OracleType.VarChar));
                cmd.Parameters["V_SYSTEM_NAME"].Value = SystemName;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void InsertNewBusiness2(string quotationNo, string branchCode, string JobType, string SystemName)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("INSERT_MNBQ_PROPOSAL_UPLOAD_2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_QUOTATION_NO", OracleType.VarChar));
                cmd.Parameters["V_QUOTATION_NO"].Value = quotationNo;

                cmd.Parameters.Add(new OracleParameter("V_ENTERED_USER_BRANCH_CODE", OracleType.VarChar));
                cmd.Parameters["V_ENTERED_USER_BRANCH_CODE"].Value = branchCode;

                cmd.Parameters.Add(new OracleParameter("V_SYSTEM_NAME", OracleType.VarChar));
                cmd.Parameters["V_SYSTEM_NAME"].Value = SystemName;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void InsertNewBusiness3(string quotationNo, string branchCode, string JobType, string SystemName)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("INSERT_MNBQ_PROPOSAL_UPLOAD_3", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_QUOTATION_NO", OracleType.VarChar));
                cmd.Parameters["V_QUOTATION_NO"].Value = quotationNo;

                cmd.Parameters.Add(new OracleParameter("V_ENTERED_USER_BRANCH_CODE", OracleType.VarChar));
                cmd.Parameters["V_ENTERED_USER_BRANCH_CODE"].Value = branchCode;

                cmd.Parameters.Add(new OracleParameter("V_SYSTEM_NAME", OracleType.VarChar));
                cmd.Parameters["V_SYSTEM_NAME"].Value = SystemName;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void InsertNewBusiness4(string quotationNo, string branchCode, string JobType, string SystemName)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("INSERT_MNBQ_PROPOSAL_UPLOAD_4", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_QUOTATION_NO", OracleType.VarChar));
                cmd.Parameters["V_QUOTATION_NO"].Value = quotationNo;

                cmd.Parameters.Add(new OracleParameter("V_ENTERED_USER_BRANCH_CODE", OracleType.VarChar));
                cmd.Parameters["V_ENTERED_USER_BRANCH_CODE"].Value = branchCode;

                cmd.Parameters.Add(new OracleParameter("V_SYSTEM_NAME", OracleType.VarChar));
                cmd.Parameters["V_SYSTEM_NAME"].Value = SystemName;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }




        public static void InsertGivenUpJob(string quotationNo, string branchCode, string JobType, string SystemName)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("INSERT_MNBQ_WF_GIVENUP_JOBS", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NO", OracleType.VarChar));
                cmd.Parameters["V_JOB_NO"].Value = quotationNo;

                cmd.Parameters.Add(new OracleParameter("V_JOB_TYPE", OracleType.VarChar));
                cmd.Parameters["V_JOB_TYPE"].Value = branchCode;

                cmd.Parameters.Add(new OracleParameter("V_FULL_PATH", OracleType.VarChar));
                cmd.Parameters["V_FULL_PATH"].Value = SystemName;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }
        //public static void UpdateEndorsement(string jobNo)
        //{
        //    OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

        //    try
        //    {
        //        OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_ENDORSEMENT", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
        //        cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (OracleException err)
        //    {
        //        // Replace the error with something less specific.
        //        // You could also log the error now.

        //        Console.WriteLine(err.ToString());
        //        throw new ApplicationException("Data error.");
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        //public static void UpdateRenewal(string jobNo)
        //{
        //    OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

        //    try
        //    {
        //        OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_RENEWAL", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
        //        cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (OracleException err)
        //    {
        //        // Replace the error with something less specific.
        //        // You could also log the error now.

        //        Console.WriteLine(err.ToString());
        //        throw new ApplicationException("Data error.");
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}


        //public static void UpdateCancellation(string jobNo)
        //{
        //    OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

        //    try
        //    {
        //        OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_CANCELLATION", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
        //        cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;



        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (OracleException err)
        //    {
        //        // Replace the error with something less specific.
        //        // You could also log the error now.

        //        Console.WriteLine(err.ToString());
        //        throw new ApplicationException("Data error.");
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        public static void UpdateEndorsement1(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_ENDORSEMENT_1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateRenewal1(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_RENEWAL_1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateCancellation1(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_CANCELLATION_1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateEndorsement2(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_ENDORSEMENT_2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateRenewal2(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_RENEWAL_2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateCancellation2(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_CANCELLATION_2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateEndorsement3(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_ENDORSEMENT_3", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateRenewal3(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_RENEWAL_3", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateCancellation3(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_CANCELLATION_3", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateEndorsement4(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_ENDORSEMENT_4", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateRenewal4(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_RENEWAL_4", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateCancellation4(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_CANCELLATION_4", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateNewBusinessFST1(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_NEWFST_1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateNewBusinessFST2(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_NEWFST_2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateNewBusinessFST3(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_NEWFST_3", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        public static void UpdateNewBusinessFST4(string jobNo)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_NEWFST_4", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }



        public static void UpdateUnknown(string jobNo, string jobType, string unknownType)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE_MNBQ_UNKNOWN", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", OracleType.VarChar));
                cmd.Parameters["V_JOB_NUMBER"].Value = jobNo;

                cmd.Parameters.Add(new OracleParameter("V_JOB_TYPE", OracleType.VarChar));
                cmd.Parameters["V_JOB_TYPE"].Value = jobType;

                cmd.Parameters.Add(new OracleParameter("V_UNKNOWN_TYPE", OracleType.VarChar));
                cmd.Parameters["V_UNKNOWN_TYPE"].Value = unknownType;





                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {
                // Replace the error with something less specific.
                // You could also log the error now.

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        private static bool WaitForFile(string jobNo, string jobType, string fullPath)
        {
            int numTries = 0;
            while (true)
            {
                ++numTries;
                try
                {
                    // Attempt to open the file exclusively.
                    using (FileStream fs = new FileStream(fullPath,
                        FileMode.Open, FileAccess.ReadWrite,
                        FileShare.None, 100))
                    {
                        fs.ReadByte();

                        // If we got this far the file is ready
                        break;
                    }
                }
                catch (Exception ex)
                {
                    CreateLogFiles Err = new CreateLogFiles();
                    Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("WaitForFile {0} failed to get an exclusive lock: {1} No of try:{2}", fullPath, ex.ToString(), numTries)));


                    if (numTries > 300)
                    {

                        InsertGivenUpJob(jobNo, jobType, fullPath);


                        Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} giving up after 300 tries", fullPath));


                        return false;
                    }

                    // Wait for the lock to be released
                    System.Threading.Thread.Sleep(1500);
                }
            }

            // Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} returning true after {1} tries", fullPath, numTries));


            return true;
        }

        private static bool WaitForFileLong(string jobNo, string jobType, string fullPath)
        {
            int numTries = 0;
            while (true)
            {
                ++numTries;
                try
                {
                    // Attempt to open the file exclusively.
                    using (FileStream fs = new FileStream(fullPath,
                        FileMode.Open, FileAccess.ReadWrite,
                        FileShare.None, 100))
                    {
                        fs.ReadByte();

                        // If we got this far the file is ready
                        break;
                    }
                }
                catch (Exception ex)
                {
                    CreateLogFiles Err = new CreateLogFiles();
                    Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("WaitForFile {0} failed to get an exclusive lock: {1} No of try:{2}", fullPath, ex.ToString(), numTries)));


                    if (numTries > 500)
                    {

                        InsertGivenUpJob(jobNo, jobType, fullPath);
                        Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} giving up after 500 tries", fullPath));


                        return false;
                    }

                    // Wait for the lock to be released
                    System.Threading.Thread.Sleep(2000);
                }
            }

            // Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} returning true after {1} tries", fullPath, numTries));


            return true;
        }

        private static bool WaitForFileLonger(string jobNo, string jobType, string fullPath)
        {
            int numTries = 0;
            while (true)
            {
                ++numTries;
                try
                {
                    // Attempt to open the file exclusively.
                    using (FileStream fs = new FileStream(fullPath,
                        FileMode.Open, FileAccess.ReadWrite,
                        FileShare.None, 100))
                    {
                        fs.ReadByte();

                        // If we got this far the file is ready
                        break;
                    }
                }
                catch (Exception ex)
                {
                    CreateLogFiles Err = new CreateLogFiles();
                    Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("WaitForFile {0} failed to get an exclusive lock: {1} No of try:{2}", fullPath, ex.ToString(), numTries)));


                    if (numTries > 700)
                    {

                        InsertGivenUpJob(jobNo, jobType, fullPath);
                        Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} giving up after 700 tries", fullPath));


                        return false;
                    }

                    // Wait for the lock to be released
                    System.Threading.Thread.Sleep(2000);
                }
            }

            // Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} returning true after {1} tries", fullPath, numTries));


            return true;
        }

        private static bool WaitForFileForGivenUpJobs(string jobNo, string jobType, string fullPath)
        {


            int numTries = 0;
            while (true)
            {
                ++numTries;
                try
                {
                    // Attempt to open the file exclusively.
                    using (FileStream fs = new FileStream(fullPath,
                        FileMode.Open, FileAccess.ReadWrite,
                        FileShare.None, 100))
                    {
                        fs.ReadByte();

                        // If we got this far the file is ready
                        break;
                    }
                }
                catch (Exception ex)
                {
                    CreateLogFiles Err = new CreateLogFiles();
                    Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("WaitForFile {0} failed to get an exclusive lock: {1} No of try:{2}", fullPath, ex.ToString(), numTries)));


                    if (numTries > 2500)
                    {

                        InsertGivenUpJob(jobNo, jobType, fullPath);
                        Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} giving up after 5000 tries", fullPath));


                        return false;
                    }

                    // Wait for the lock to be released
                    System.Threading.Thread.Sleep(2000);
                }
            }

            // Err.ErrorLog(Properties.Settings.Default.LogFileName, String.Format("WaitForFile {0} returning true after {1} tries", fullPath, numTries));


            return true;
        }
        public static void InsertGivenUpJob(string jobNo, string jobType, string filePath)
        {
            OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);

            try
            {
                OracleCommand cmd = new OracleCommand("INSERT_MNBQ_WF_GIVENUP_JOBS", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_JOB_NO", OracleType.VarChar));
                cmd.Parameters["V_JOB_NO"].Value = jobNo;

                cmd.Parameters.Add(new OracleParameter("V_JOB_TYPE", OracleType.VarChar));
                cmd.Parameters["V_JOB_TYPE"].Value = jobType;

                cmd.Parameters.Add(new OracleParameter("V_FULL_PATH", OracleType.VarChar));
                cmd.Parameters["V_FULL_PATH"].Value = filePath;



                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OracleException err)
            {

                Console.WriteLine(err.ToString());
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }


        private static bool validateQuotationNoFromDB(string quotationNo, string jobType)
        {
            bool returnVal = false;
            try
            {
                OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);
                OracleDataReader dr;

                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                String selectQuery = "";





                if (jobType == "NEW")
                {
                    if (quotationNo.Substring(5, 1) == "T" || quotationNo.Substring(5, 1) == "t")
                    {
                        selectQuery = "   SELECT " +
                                       "T.QUOTATION_NO  " +
                                       " FROM  MNBQ_T_MAIN T " +
                                       " WHERE T.QUOTATION_NO='" + quotationNo + "'    ";
                    }
                    else
                    {

                        selectQuery = "   SELECT " +
                                    "T.QUOTATION_NO  " +
                                    " FROM  MNBQ_MAIN T " +
                                    " WHERE T.QUOTATION_NO='" + quotationNo + "'    ";
                    }

                }
                else
                {
                    selectQuery = "   SELECT " +
                         "T.job_number  " +
                         " FROM  mnbq_proposal_upload T " +
                         " WHERE T.job_number='" + quotationNo + "'    ";

                }



                cmd.CommandText = selectQuery;

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //dr.Read();

                    returnVal = true;
                }
                dr.Close();
                dr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();


            }
            catch (Exception)
            {

                throw;
            }
            return returnVal;


        }

        private static bool validateStatusOfJob(string quotationNo, string jobType)
        {
            bool returnVal = false;
            try
            {
                OracleConnection con = new OracleConnection(Properties.Settings.Default.DBConString);
                OracleDataReader dr;

                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                String selectQuery = "";

                if (jobType == "NEW")
                {
                    if (quotationNo.Substring(5, 1) == "T" || quotationNo.Substring(5, 1) == "t")
                    {
                        selectQuery = "   SELECT " +
                                       "T.STATUS  " +
                                       " FROM  MNBQ_T_MAIN T " +
                                       " WHERE T.QUOTATION_NO='" + quotationNo + "'    ";
                    }
                    else
                    {
                        selectQuery = "   SELECT " +
                                             "T.STATUS  " +
                                             " FROM  MNBQ_MAIN T " +
                                             " WHERE T.QUOTATION_NO='" + quotationNo + "'    ";
                    }
                }
                else
                {
                    selectQuery = "   SELECT " +
                         "T.STATUS  " +
                         " FROM  mnbq_proposal_upload T " +
                         " WHERE T.job_number='" + quotationNo + "'    ";

                }



                cmd.CommandText = selectQuery;

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //dr.Read();

                    returnVal = true;
                }
                dr.Close();
                dr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();

            }
            catch (Exception)
            {

                throw;
            }
            return returnVal;

        }

        //private static void ProcessCancellationFolder(object sender, FileSystemEventArgs e)
        //{
        //    bool isValidJob = true;
        //    FileInfo file = new FileInfo(e.FullPath);


        //    Console.WriteLine("Cancellation Received.... ");

        //    DirectoryInfo dest = new DirectoryInfo(@Properties.Settings.Default.PathQueuedCancellation);



        //    string jobNo = "";
        //    string branchCode = "";
        //    string unknownType = "";

        //    jobNo = file.Name;

        //    if (!validateQuotationNoFromDB(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
        //    {
        //        isValidJob = false;
        //        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
        //        unknownType = Properties.Settings.Default.UnknownInvalidJobNo;

        //    }
        //    if (!validateStatusOfJob(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION"))
        //    {
        //        isValidJob = false;
        //        dest = new DirectoryInfo(@Properties.Settings.Default.PathUnknownCancellation);
        //        unknownType = Properties.Settings.Default.UnknownAlreadyCompletedJob;
        //    }
        //    if (!Directory.Exists(dest.FullName + jobNo.ToUpper()))
        //    {
        //        System.IO.Directory.CreateDirectory(dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
        //    }



        //    string outputFileWithPath = "";
        //    outputFileWithPath = dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\" + file.Name.ToUpper();


        //    if (jobNo.Length > 10)
        //    {
        //        branchCode = jobNo.Substring(2, 3);
        //    }

        //    Console.WriteLine(jobNo + " -     " + branchCode);
        //    try
        //    {

        //        if (File.Exists(outputFileWithPath))
        //        {
        //            string temPathForMerge = "";
        //            temPathForMerge = dest.FullName + jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper() + "\\TEMP_" + file.Name.ToUpper();
        //            //To merge PDFs if there are more than multiple PDFs scanned from different branches
        //            MergePDFs(temPathForMerge, file.FullName, outputFileWithPath);

        //            string bkpDoc = "";
        //            bkpDoc = outputFileWithPath + ".bak";

        //            if (WaitForFile(file.FullName))
        //            {
        //                File.Replace(temPathForMerge, outputFileWithPath, bkpDoc, false);
        //                File.Delete(file.FullName);
        //            }
        //        }
        //        else
        //        {
        //            if (WaitForFile(file.FullName))
        //            {
        //                File.Move(file.FullName, outputFileWithPath);
        //            }
        //        }



        //        if (isValidJob)
        //        {
        //            UpdateCancellation(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper());
        //        }
        //        else
        //        {
        //            UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());

        //        CreateLogFiles Err = new CreateLogFiles();
        //        Err.ErrorLog(Properties.Settings.Default.LogFileName, (String.Format("Error while processing {0} : {1}", jobNo, ex.ToString())));

        //        unknownType = Properties.Settings.Default.UnknownFileError;
        //        UpdateUnknown(jobNo.Substring(0, file.Name.LastIndexOf(".")).ToUpper(), "CANCELLATION", unknownType);
        //    }


        //}
    }
}
