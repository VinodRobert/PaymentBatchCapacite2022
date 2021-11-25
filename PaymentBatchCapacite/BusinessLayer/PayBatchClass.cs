using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using Syncfusion.WinForms.DataGrid.Renderers;

namespace PaymentBatchCapacite
{
    

    public class PaymentBatch
    {
        private int m_batchID;
        private string m_batchProcess;
        private string m_batchNO;
        private string m_narration;
        private string m_bsBorgName;
        private string m_partyCode;
        private string m_partyName;
        private decimal m_batchOutstanding;
        private decimal m_cilOutstanding;
        private decimal m_projectOutstanding;
        private decimal m_gstOutstanding;
        private string m_batchOwner;
        private int m_detailID;
        private bool m_selected;

        public bool Selected
        {
            get { return m_selected; }
            set { m_selected = value; }
        }

        public int DetailID
        {
            get { return m_detailID; }
            set { m_detailID = value;  }
        }

        public int BatchID
        {
            get { return m_batchID; }
            set { m_batchID = value; }
        }

        public string BatchProcess
        {
            get { return m_batchProcess; }
            set { m_batchProcess = value; }
        }

        public string BatchNo
        {
            get { return m_batchNO; }
            set { m_batchNO = value; }
        }

        public string Narration
        {
            get { return m_narration; }
            set { m_narration = value; }
        }

        public string BSBorgName
        {
            get { return m_bsBorgName; }
            set { m_bsBorgName = value; }
        }

        public string PartyCode
        {
            get { return m_partyCode; }
            set { m_partyCode = value; }
        }

        public string PartyName
        {
            get { return m_partyName; }
            set { m_partyName = value; }
        }


        public Decimal BatchOutstanding
        {
            get { return m_batchOutstanding; }
            set { m_batchOutstanding = value; }
        }

        public Decimal CILOutstanding
        {
            get { return m_cilOutstanding; }
            set { m_cilOutstanding = value; }
        }

        public Decimal ProjectOutstanding
        {
            get { return m_projectOutstanding; }
            set { m_projectOutstanding = value; }
        }

        public Decimal GSTOutstanding
        {
            get { return m_gstOutstanding; }
            set { m_gstOutstanding = value; }
        }

        public string BatchOwner
        {
            get { return m_batchOwner; }
            set { m_batchOwner = value;  }
        }


        public PaymentBatch(bool selected,int batchID,int detailID,string batchProcess,string batchNo,string narration,string bsBorgName,string partyCode,string partyName,decimal batchOutstanding,decimal cilOutstanding,decimal projectOutstanding,decimal gstOutstanding,string batchOwner)
        {
            m_batchID = batchID;
            m_detailID = detailID;
            m_batchProcess = batchProcess;
            m_batchNO = batchNo;
            m_narration = narration;
            m_bsBorgName = bsBorgName;
            m_partyCode = partyCode;
            m_partyName = partyName;
            m_batchOutstanding = batchOutstanding;
            m_cilOutstanding = cilOutstanding;
            m_projectOutstanding = projectOutstanding;
            m_gstOutstanding = gstOutstanding;
            m_batchOwner = batchOwner;
            m_selected = selected;
        }

       
    }

    public class ApprovedPaymentBatch
    {
        private int m_batchID;
        private string m_batchProcess;
        private string m_batchNO;
        private string m_narration;
        private string m_bsBorgName;
        private string m_partyCode;
        private string m_partyName;
        private decimal m_batchOutstanding;
        private int m_detailID;
        private bool m_selected;

        public bool Selected
        {
            get { return m_selected; }
            set { m_selected = value; }
        }

        public int DetailID
        {
            get { return m_detailID; }
            set { m_detailID = value; }
        }

        public int BatchID
        {
            get { return m_batchID; }
            set { m_batchID = value; }
        }

        public string BatchProcess
        {
            get { return m_batchProcess; }
            set { m_batchProcess = value; }
        }

        public string BatchNo
        {
            get { return m_batchNO; }
            set { m_batchNO = value; }
        }

        public string Narration
        {
            get { return m_narration; }
            set { m_narration = value; }
        }

        public string BSBorgName
        {
            get { return m_bsBorgName; }
            set { m_bsBorgName = value; }
        }

        public string PartyCode
        {
            get { return m_partyCode; }
            set { m_partyCode = value; }
        }

        public string PartyName
        {
            get { return m_partyName; }
            set { m_partyName = value; }
        }


        public Decimal BatchOutstanding
        {
            get { return m_batchOutstanding; }
            set { m_batchOutstanding = value; }
        }

       


        public ApprovedPaymentBatch (bool selected, int batchID, int detailID, string batchProcess, string batchNo, string narration, string bsBorgName, 
                                     string partyCode, string partyName, decimal batchOutstanding)
        {
            m_batchID = batchID;
            m_detailID = detailID;
            m_batchProcess = batchProcess;
            m_batchNO = batchNo;
            m_narration = narration;
            m_bsBorgName = bsBorgName;
            m_partyCode = partyCode;
            m_partyName = partyName;
            m_batchOutstanding = batchOutstanding;
            m_selected = selected;
        }



    }


    public class RTGSLetter
    {
        private int m_rtgsID;
        private string m_reference;
        private string m_yearReference;
        private int m_serialNumber;
        private string m_bankName;
        private string m_bankAccount;
        private string m_addressLine1;
        private string m_addressLine2;
        private string m_addressLine3;
        private string m_state;
        private string m_PIN;
        private decimal m_totalAmount;
        private string m_amountInWords;

        private int RTGSID
        {
            get { return m_rtgsID; }
            set { m_rtgsID = value; }
        }
        public string Reference
        {
            get { return m_reference; }
            set { m_reference = value; }
        }

        public string YearReference
        {
            get { return m_yearReference; }
            set { m_yearReference = value; }
        }

        public int SerialNumber
        {
            get { return m_serialNumber; }
            set { m_serialNumber = value; }
        }

        public string BankName
        {
            get { return m_bankName; }
            set { m_bankName = value; }
        }

        public string BankAccount
        {
            get { return m_bankAccount; }
            set { m_bankAccount = value; }
        }

        public string AddressLine1
        {
            get { return m_addressLine1; }
            set { m_addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return m_addressLine2; }
            set { m_addressLine2 = value; }
        }

        public string AdddressLin3
        {
            get { return m_addressLine3; }
            set { m_addressLine3 = value; }
        }

        public string State
        {
            get { return m_state; }
            set { m_state = value; }
        }

        public string PIN
        {
            get { return m_PIN; }
            set { m_PIN = value; }
        }


        public Decimal TotalAmount
        {
            get { return m_totalAmount; }
            set { m_totalAmount = value; }
        }

        public string AmountInWords
        {
            get { return m_amountInWords; }
            set { m_amountInWords = value; }
        }


        public RTGSLetter(string reference,string yearReference,int serialNumber,string bankName,string bankAccount, string address1,string address2,string address3,string state,string pin,
            decimal totalAmount,string amountInWords,int rtgsID)
        {
            m_reference = reference;
            m_yearReference = yearReference;
            m_bankAccount = bankAccount;
            m_bankName = bankName;
            m_addressLine1 = address1;
            m_addressLine2 = address2;
            m_addressLine3 = address3;
            m_state = state;
            m_PIN = pin;
            m_totalAmount = totalAmount;
            m_amountInWords = amountInWords;
            m_rtgsID = rtgsID;
        }
    }

    public class Beneficiary
    {
        private int m_rtgsID;
        private string m_beneficiaryName;
        private string m_bankAccountNumber;
        private string m_ifscCode;
        private decimal m_amount;
        
        public int RTGSID
        {
            get { return m_rtgsID; }
            set { m_rtgsID = value; }
        }

        public string BeneficiaryName
        {
            get { return m_beneficiaryName; }
            set { m_beneficiaryName = value; }
        }

        public string BankAccountNumber
        {
            get { return m_bankAccountNumber; }
            set { m_bankAccountNumber = value; }
        }

        public Decimal Amount
        {
            get { return m_amount; }
            set { m_amount = value; }
        }


        public Beneficiary(int rtgsID,string beneficiaryName,string bankAccountNumber,decimal amount)
        {
            m_rtgsID = rtgsID;
            m_beneficiaryName = beneficiaryName;
            m_bankAccountNumber = bankAccountNumber;
            m_amount = amount; 

        }
    }


    public class LetterHeadFormat
    {
        private int m_formatID;
        private string m_formatName;
        public int FormatID
        {
            get { return m_formatID; }
            set { m_formatID = Convert.ToInt16(value); } 
        }

        public string FormatName 
        {
            get {return m_formatName; }
            set {m_formatName = value; }
        }

        public LetterHeadFormat(int letterHeadID, string letterHeadName)
        {
            m_formatID = letterHeadID;
            m_formatName = letterHeadName;
        }
    }

    public class Project
    {
        private int m_projectID;
        private string m_projectName;
        public int ProjectID
        {
            get { return m_projectID; }
            set { m_projectID = Convert.ToInt16(value); }
        }

        public string ProjectName
        {
            get { return m_projectName; }
            set { m_projectName = Convert.ToString(value); }
        }

        public Project(int projectId, string projectName)
        {
            m_projectID = projectId;
            m_projectName = projectName;
        }

    }

    public class PBBanks
    {
        private int m_bankID;
        private string m_bankName;

        public int BankID
        {
            get { return m_bankID; }
            set { m_bankID = Convert.ToInt16(value); }
        }

        public string BankName
        {
            get { return m_bankName; }
            set { m_bankName = Convert.ToString(value); }
        }

        public PBBanks(int bankID, string bankName)
        {
            m_bankID = bankID;
            m_bankName = bankName;
        }

    }


    public class PBUsers
    {
        private string m_loginID;
        private string m_userName;

        public string LoginID
        {
            get { return m_loginID; }
            set { m_loginID = Convert.ToString(value); }
        }

        public string UserName
        {
            get { return m_userName; }
            set { m_userName = Convert.ToString(value); }
        }

        public PBUsers(string loginID,string userName)
        {
            m_loginID = loginID;
            m_userName = userName;
        }

    }

    public class PBApprovalLevels
    {
        private int m_approveLevelID;
        private string m_levelName;

        public int ApprovalLevelID
        {
            get { return m_approveLevelID; }
            set { m_approveLevelID = Convert.ToInt16(value); }
        }

        public string LevelName
        {
            get { return m_levelName; }
            set { m_levelName = Convert.ToString(value); }
        }

        public PBApprovalLevels(int approvalLevelID,string levelName)
        {
            m_approveLevelID = approvalLevelID;
            m_levelName = levelName;
        }

    }


    public static class SqlString
    {
        /// <summary>
        /// This Extension method will replace the single qoutes ' to ''..
        /// So Sql single qoutes exception will never raise
        /// </summary>
        /// <param name="fieldvalue"></param>
        /// <returns></returns>
        public static string GetSqlString(this string fieldvalue)
        {
            if (fieldvalue != null)
                return fieldvalue.Replace("'", "''");
            return fieldvalue;
        }
    }



    class PayBatchClass
    {

       
        public DataSet getIFSC()
        {
            string connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT IFSCCODE FROM PB.BENEFICIARYBANKS WHERE  UPDATED=0";
            DataSet ds = SqlHelper.ExecuteDataset(connectionString, CommandType.Text, sql);
            return  ds;
        }


        public int UpdateBankDetailsFromIFSC(string ifsc,string bankName,string branchName)
        {
            string connectionString = SqlHelper.GetConnectionString();
            string sql = "UPDATE PB.BENEFICIARYBANKS SET UPDATED=1, BANKNAME='"+bankName.Trim()+"', BRANCHNAME='"+branchName.Trim()+"' WHERE IFSCCODE='"+ifsc.Trim()+"'"   ;
            int i = SqlHelper.ExecuteNonQuery(connectionString, CommandType.Text, sql);
            return i;
        }


        public DataSet Login(string UserID, string Password)
        {
            DataSet _ds;
            string _connectionString = SqlHelper.GetConnectionString();

            string _sql = "UPDATE PB.paymentbatchusers  set bspassword=users.PASSWORD from users inner join PB.paymentbatchusers PBU ON PBU.BSLOGINID =USERS.LOGINID";
       //     int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);

            _sql = "Select * from PB.PaymentBatchUsers where BSLOGINID='" + Convert.ToString(UserID).Trim() + "'  AND BSPASSWORD='" + Convert.ToString(Password) + "'";
            _ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return _ds;
        }

        public DataSet SelectProjectWorking(string UserID)
        {
            DataSet _ds;
            string _connectionString = SqlHelper.GetConnectionString();

            string _sql = "SELECT DISTINCT   B.BSORGID,B.BSORGNAME FROM [PB].[PAYMENTBATCHORGS] B WHERE BSORGID  IN  (SELECT BSORGID FROM PB.PAYMENTBATCHUSERORGROLEMAPPING WHERE BSLOGINID= '";
            _sql = _sql + Convert.ToString(UserID).Trim() + "'  AND APPROVERLEVELID = 1 )  ORDER BY BSORGNAME ";
            _ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return _ds;
        }

        public DataSet GetBatches(string batchOwer,string batchStatus)
        {
            DataSet _ds;
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@BATCHOWER", SqlDbType.Text);
            arParms[0].Value = Convert.ToString(batchOwer);
            arParms[1] = new SqlParameter("@BATCHSTATUS", SqlDbType.Text);
            arParms[1].Value = Convert.ToString(batchStatus);
            arParms[2] = new SqlParameter("@PROJECTLISTS", SqlDbType.Text);
            string projectLists = Convert.ToString(GlobalVariables.projectLists);
            arParms[2].Value = Convert.ToString(projectLists);
            _ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[PB].[spGetBatches]",arParms);
            return _ds;
        }

        public int ChangeBatchStatus(int batchID,int detailID,string partyCode)
        {
            int success;
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@BATCHID", SqlDbType.Int);
            arParms[0].Value = Convert.ToInt16(batchID);
            arParms[1] = new SqlParameter("@DETAILID", SqlDbType.Int);
            arParms[1].Value = Convert.ToInt16(detailID);
            arParms[2] = new SqlParameter("@PARTYCODE", SqlDbType.Text);
            arParms[2].Value = Convert.ToString(partyCode);
            success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "[PB].[spChangeBatchStatus]", arParms);
            return success;
        }


        public DataSet GetProjectsNotEnrolledForPaymentBatch()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql;
            _sql = "Select 65 as BORGID ,'99999-BMT Test Environment' BORGNAME  UNION ";
            _sql = _sql +  "SELECT BORGID,BORGNAME FROM BORGS  WHERE BORGID NOT IN (SELECT BSORGID FROM PB.PAYMENTBATCHORGS ) AND PARENTBORG  IN(23,24,25,26,27,172,209)   ORDER BY BORGNAME  ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public DataSet GetProjectsEnrolledForPaymentBatch()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT * FROM PB.PAYMENTBATCHORGS ORDER BY BSORGID ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public int EnablePaymentBatch(int borgID, string projectName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "INSERT INTO PB.PAYMENTBATCHORGS VALUES(" + Convert.ToString(borgID) + ",'" + Convert.ToString(projectName) + "')";
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            _sql = "INSERT INTO BATCHREMIT(BATCHNO,BATORGID,BATPROCESS,BATDESC,BATSTATUS,BATDATEOPEN,BATUPDATE,BATPERIOD,BATYEAR,BATOWNER,BATCURRENCY,BATBANK)";
            _sql = _sql + "  VALUES(999, " + Convert.ToString(borgID) + ", 'C', 'System Generated', -1, GETDATE(), NULL, 0, 2020, 'admin', 'ALL', 0)";
            _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            _sql = "INSERT INTO BATCHREMIT(BATCHNO,BATORGID,BATPROCESS,BATDESC,BATSTATUS,BATDATEOPEN,BATUPDATE,BATPERIOD,BATYEAR,BATOWNER,BATCURRENCY,BATBANK)";
            _sql = _sql + "  VALUES(999, " + Convert.ToString(borgID) + ", 'S', 'System Generated', -1, GETDATE(), NULL, 0, 2020, 'admin', 'ALL', 0)";
            _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return _success;
        }


        public DataSet GetPaymentBatchUsers()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT PBU.BSLOGINID,PBU.BSUSERNAME,PBR.LEVELNAME,PBU.APPROVERLEVELID FROM PB.PAYMENTBATCHUSERS PBU INNER JOIN PB.APPROVALLEVELS PBR ON PBR.APPROVERLEVELID = PBU.APPROVERLEVELID ORDER BY[BSUSERNAME] ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public DataSet GetRemainingBSUsers()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT LOGINID,USERNAME FROM USERS WHERE LOCKED=0 AND LOGINID NOT IN (SELECT BSLOGINID FROM PB.PAYMENTBATCHUSERS) ORDER BY USERNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }


        public DataSet GetPaymentBatchRoles()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT APPROVERLEVELID, LEVELNAME FROM PB.APPROVALLEVELS ORDER BY LEVELCODE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public DataSet GetPaymentBatchRolesMasters()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT  LEVELCODE,LEVELID,LEVELNAME FROM  PB.APPROVALLEVELS ORDER BY LEVELCODE  ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }


        public DataSet GetPaymentBatchUserPassword(string bsLoginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT PASSWORD FROM USERS WHERE LOGINID='" + Convert.ToString(bsLoginID).TrimEnd() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public int UpdatePaymentBatchUsers(string bsLoginID, string bsLoginName, string bsLoginPassword, string pbRoleName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "INSERT INTO PB.PAYMENTBATCHUSERS VALUES('" + Convert.ToString(bsLoginID).TrimEnd() + "','" + Convert.ToString(bsLoginName) + "','" + Convert.ToString(bsLoginPassword).TrimEnd() + "'," + Convert.ToString(pbRoleName) + ")";
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return _success;
        }


        public int DeletePBUserWithRole(string loginID,int roleID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "DELETE FROM PB.PAYMENTBATCHUSERS WHERE BSLOGINID='"+Convert.ToString(loginID)+"' AND APPROVERLEVELID=" + Convert.ToString(roleID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return i;
        }

        public DataSet GetBorgid(string borgName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT BORGID FROM BORGS WHERE BORGNAME='" + Convert.ToString(borgName).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public DataSet RTGSReport(int rtgsHeaderID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT H.RTGSID,H.RTGSNumber RTGSReferenceNumber,H.RTGSDate,H.BATCHTOTALAMOUNT,H.BatchTotalAmountInWords,";
            sql = sql + " B.BANKNAME,B.BANKREFERENCECODE,B.BANKACCOUNT,B.ACCOUNTTYPE,B.SALUTATION,B.ADDRESS1,B.ADDRESS2,B.ADDRESS3,B.STATE,B.PIN,B.LETTERHEADID,B.BANKBRANCH ";
            sql = sql + " FROM PB.RTGSHEADER H  INNER JOIN  PB.PAYMENTBANKS B ON H.BANKID = B.BANKID ";
            sql = sql + " WHERE H.RTGSID = " + Convert.ToString(rtgsHeaderID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet RTGSBeneficiaryList(int rtgsHeaderID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT H.RTGSID,H.RTGSNUMBER RTGSReferenceNumber,H.RTGSDATE,D.RTGSDETAILID,D.RTGSHEADERID,D.BATCHDETAILID,D.BENEFICIARYNAME,D.BENEFICIARYACCOUNTNUMBER,D.IFSCCODE,D.PAYMENTAMOUNT ";
            sql = sql + " FROM PB.RTGSHEADER H INNER JOIN PB.RTGSDETAIL D ON H.RTGSID = D.RTGSHEADERID ";
            sql = sql + " WHERE RTGSHEADERID = " + Convert.ToString(rtgsHeaderID) + " ORDER BY BENEFICIARYNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet RTGSBeneficiaryListForPosting(int rtgsHeaderID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql =" SELECT   B.BANKNAME,B.BANKACCOUNT,   H.BATCHNO,CASE WHEN H.BATPROCESS = 'C' THEN 'Supplier'   WHEN H.BATPROCESS = 'S' THEN 'Sub-Contrator' END AS CATEGORY,BD.PARTYCODE,  ";
            sql = sql + "  D.BENEFICIARYNAME,D.BENEFICIARYACCOUNTNUMBER,D.IFSCCODE,D.PAYMENTAMOUNT,D.UTRNUMBER,B.BANKREFERENCECODE   FROM  PB.RTGSDETAIL D ";
            sql = sql + "  INNER JOIN PB.RTGSHEADER RH ON RH.RTGSID = D.RTGSHeaderID   INNER JOIN PB.PAYMENTBATCHDETAIL BD ON D.BATCHDETAILID = BD.DETAILID ";
            sql = sql + "  INNER JOIN PB.PAYMENTBATCHHEADER H ON BD.BATCHID = H.BATCHID   LEFT OUTER  JOIN PB.PAYMENTBANKS B ON RH.BANKID = B.BANKID ";
            sql = sql + "  WHERE RTGSHEADERID = " + Convert.ToString(rtgsHeaderID) + " ORDER BY BENEFICIARYNAME ";
           
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }



        public DataSet RTGSCheque(int rtgsHeaderID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT  1 CHEQUEID, H.RTGSID, H.RTGSDATE, 'Yourself for RTGS' BENEFICIARY, H.BATCHTOTALAMOUNT AMOUNT , H.BATCHTOTALAMOUNTINWORDS AMOUNTINWORDS ";
            sql = sql + " FROM PB.RTGSHEADER H WHERE H.RTGSID = " + Convert.ToString(rtgsHeaderID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet GetPaymentBatchUserRole(string bsLoginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT L.LEVELNAME,L.APPROVERLEVELID FROM PB.APPROVALLEVELS L WHERE APPROVERLEVELID = (SELECT APPROVERLEVELID FROM PB.PAYMENTBATCHUSERS WHERE BSLOGINID = '" + Convert.ToString(bsLoginID).Trim() + "');";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }
        public DataSet GetProjectAssignment(string bsLoginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "  SELECT O.BSORGNAME, CASE WHEN PBU.BSPROCESS = 'C' THEN 'Creditors'   WHEN PBU.BSPROCESS = 'S' THEN 'SubContractors'  END AS BSPROCESS, L.LEVELNAME ";
            _sql = _sql + "  FROM PB.PAYMENTBATCHUSERORGROLEMAPPING PBU INNER JOIN PB.PAYMENTBATCHORGS O ON PBU.BSORGID = O.BSORGID  INNER JOIN PB.APPROVALLEVELS L ON PBU.APPROVERLEVELID = L.APPROVERLEVELID ";
            _sql = _sql + "  WHERE PBU.BSLOGINID = '" + Convert.ToString(bsLoginID).Trim() + "';";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public int UpdatePBUserProjectMapping(string loginID, int borgID, string processID, int userApproverLevelID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "Select isnull( count(*),0) Counts from PB.PAYMENTBATCHUSERORGROLEMAPPING where bsloginid='" + Convert.ToString(loginID) + "' and bsorgid='" + Convert.ToString(borgID) + "'";
            _sql = _sql + " and bsprocess='" + Convert.ToString(processID) + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            int counter = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            if (counter >= 1)
                return 0;
            _sql = "insert into PB.PAYMENTBATCHUSERORGROLEMAPPING(bsloginid,bsorgid,bsprocess,APPROVERLEVELID) values(";
            _sql = _sql + "'" + Convert.ToString(loginID) + "'," + Convert.ToString(borgID) + ",'" + Convert.ToString(processID) + "'," + Convert.ToString(userApproverLevelID) + ")";
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return k;
        }

        public int ResetMapping(string loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "DELETE FROM  PB.PAYMENTBATCHUSERORGROLEMAPPING WHERE BSLOGINID='" + Convert.ToString(loginID).Trim() + "'";
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return k;
        }

        public DataSet ActiveRTGSForAction(string loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT DISTINCT  H.RTGSID,H.RTGSNUMBER,B.BANKNAME,B.BANKACCOUNT,H.BATCHTOTALAMOUNT,H.BATCHTOTALAMOUNTINWORDS,H.RTGSSTATUS ";
            _sql = _sql + " FROM PB.RTGSHEADER H  INNER JOIN PB.PAYMENTBANKS B ON H.BANKID = B.BANKID ";
            _sql = _sql + " WHERE H.LoginID = '" + Convert.ToString(loginID) + "' AND RTGSSTATUS=0   ORDER BY RTGSNUMBER ";
            DataSet ds  = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }

        public DataSet OpenRTGSForAction(string loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT RTGSNUMBER,RTGSID FROM PB.RTGSHEADER WHERE RTGSSTATUS=1 AND LOGINID='" + Convert.ToString(loginID) + "'  ORDER BY RTGSDATE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            return ds;
        }


        public DataSet GetRTGSLetter(int rtgsID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@RTGSID", SqlDbType.Int);
            arParms[0].Value = Convert.ToInt32(rtgsID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "PB.spRTGSLetter", arParms);
            return ds;
        }


        public DataSet  GetPaymentBatchBanks(int borgID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = Convert.ToInt16(borgID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[PB].[spGetPaymentBanks]", arParms);
            return ds;
        }
         
        public int UpdateBankAddress(int bankID,string accountNumber,string address1,string address2,string address3,string bankName,string pin,string state)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "UPDATE PB.PAYMENTBANKS set Address1='" + Convert.ToString(address1).Trim() + "',Address2='" + Convert.ToString(address2).Trim() + "',Address3='";
            _sql = _sql + Convert.ToString(address3).Trim() + "',BankName='" + Convert.ToString(bankName).Trim() + "',pin='" + Convert.ToString(pin) + "',state='" + Convert.ToString(state).Trim();
            _sql = _sql + "',bankAccount='"+Convert.ToString(accountNumber)+"'";
            _sql = _sql + "   WHERE BANKID =" + Convert.ToString(bankID);
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return k;
        }
      
        public int UpdateReference(int bankID, string reference, int serialNumber, string yearReference, int cheque,int rtgs, int api,string salutation,int letterID,string accountType,string branchName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "UPDATE PB.PAYMENTBANKS set Reference='" + Convert.ToString(reference).Trim() + "',SerialNumber=" + Convert.ToString(serialNumber).Trim() + ",YearReference='";
            _sql = _sql + Convert.ToString(yearReference).Trim() + "',cheque=" + Convert.ToString(cheque).Trim() + ",rtgs=" + Convert.ToString(rtgs) + ",api=" + Convert.ToString(api).Trim();
            _sql = _sql + ",LETTERHEADID=" + Convert.ToString(letterID) + ",SALUTATION='" + Convert.ToString(salutation) + "',BANKREFERENCECODE='"+Convert.ToString(reference).Trim()+"'" ;
            _sql = _sql + ",BANKBRANCH='" + Convert.ToString(branchName).Trim() + "',ACCOUNTTYPE='" + Convert.ToString(accountType) + "'  ";
            _sql = _sql + "   WHERE BANKID =" + Convert.ToString(bankID);
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return k;
        }

        
        public DataSet CheckWhetherOpenWalletsExists(string loginID,int  borgID, int bankID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@LOGINID", SqlDbType.Text);
            arParms[0].Value = Convert.ToString(loginID);
            arParms[1] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[1].Value = Convert.ToInt16(borgID);
            arParms[2] = new SqlParameter("@BANKID", SqlDbType.Int);
            arParms[2].Value = Convert.ToInt16(bankID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[PB].[spGetOpenWallets]", arParms);
            return ds;
        }

        
        public int UpdateRTGSWallet(int rtgsID,int detailID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@RTGSID", SqlDbType.Int);
            arParms[0].Value = Convert.ToInt16(rtgsID);
            arParms[1] = new SqlParameter("@DETAILID", SqlDbType.Int);
            arParms[1].Value = Convert.ToInt16(detailID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "PB.spAddToRTGSWallet", arParms);
            return i;
        }

        public int NewRTGSWallet(string loginID,int borgID,int bankID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string  _sqlLastNumber = "Select ISNULL(Max(RTGSID),1)  maxRTGDID FROM PB.RTGSHEADER ";

            var rtgsID = SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, _sqlLastNumber);
            
            string _sqlInserRTGSHeader = "INSERT INTO PB.RTGSHEADER values (" + Convert.ToInt16(rtgsID) + "," + Convert.ToString(borgID) + ",'" + Convert.ToString(loginID) + "'," + Convert.ToString(bankID) + ",'" + DateTime.Now + "','',0)";

            return 1;
                 
        }

        public int RemoveFromRTGSWallet(int rtgsHeaderID, string beneficiary)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@RTGSHEADERID", SqlDbType.Int);
            arParms[0].Value = Convert.ToInt16(rtgsHeaderID);
            arParms[1] = new SqlParameter("@BENEFICIARY", SqlDbType.Text);
            arParms[1].Value = Convert.ToString(beneficiary);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "PB.spRemoveFromRTGSWallet", arParms);
            return i;
        }


        public DataSet GetBatchStatus()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "PB.spTrackMyBatch" );
            return ds;
        }

        public string GetProjectOfBatch(int batchID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT B.BORGNAME FROM BORGS B WHERE BORGID = (SELECT BATORGID FROM PB.PAYMENTBATCHHEADER WHERE BATCHID = " + Convert.ToString(batchID) + ") ";
            string projectName = SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql).ToString();
            return projectName;
        }

        public string GetSupplier(string supplierCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT LTRIM(RTRIM(CREDNUMBER))+'-'+LTRIM(RTRIM(CREDNAME)) PARTYNAME FROM CREDITORS WHERE CREDNUMBER='"+Convert.ToString(supplierCode)+"'";
            string supplierName = SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql).ToString();
            return supplierName;
        }

        public string GetSubContractor(string subConCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT LTRIM(RTRIM(SUBNUMBER))+'-'+LTRIM(RTRIM(SUBNAME)) PARTYNAME FROM SUBCONTRACTORS WHERE SUBNUMBER='" + Convert.ToString(subConCode) + "'";
            string subConName = SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql).ToString();
            return subConName;
        }

        public DataSet GetProjectOutstanding(int batchID,string batchNumber, string partyCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT TRANGRP,TRANSID,PDATE,TRANSREFEXT,TRANSTYPE,CREDIT,PAIDTODATE,PAIDTHISPERIOD FROM TRANSACTIONS WHERE ORGID=";
            sql = sql + "( SELECT BATORGID FROM PB.PAYMENTBATCHHEADER WHERE BATCHID=" + Convert.ToString(batchID) + ")";
            sql = sql +   " AND RECONSTATUS= " + Convert.ToString(batchNumber) + "  AND CREDNO='" + Convert.ToString(partyCode) + "' ORDER BY TRANSID ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetCILOutstanding(string partyCode,string partyType)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@PARTYCODE", SqlDbType.Text);
            arParms[0].Value = Convert.ToString(partyCode);
            arParms[1] = new SqlParameter("@PARTYCATEGORY", SqlDbType.Text);
            arParms[1].Value = Convert.ToString(partyType);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "PB.getCILOutstanding", arParms);
            return ds;
        }

        public DataSet GetAllPaymentBanks()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT BANKID,BANKNAME+'   A/c No ' +ltrim(rtrim(bankaccount)) as BankName from pb.paymentbanks order by bankName ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int lastUTRHeaderID()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT ISNULL(MAX(UTRHEADID),0) FROM PB.UTRHEADER";
            int lastUTRHeaderID =Convert.ToInt16( SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql) );
            return lastUTRHeaderID;
        }
        

        public int CloseRTGSHeader(int rtgsID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "UPDATE  PB.RTGSHEADER   SET RTGSSTATUS=1 WHERE RTGSID = " + Convert.ToString(rtgsID);
            int success = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql));
            return success;
        }

        public int UnlockBatch(int batchID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "UPDATE PB.PAYMENTBATCHHEADER SET APPROVERLEVELID=1 WHERE APPROVERLEVELID=2 AND BATCHID= " + Convert.ToString(batchID);
            int success = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql));
            return success;
        }

        public int PostToBuildsmart(int rtgsID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@RTGSHEADID", SqlDbType.Int);
            arParms[0].Value = Convert.ToInt16(rtgsID);
            
            int success = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.StoredProcedure, "PB.spPostToBuildSmart", arParms));
            return success;
        }


        public int addUTRHeader(int utrHeaderID, int bankID, DateTime fromDate, DateTime ToDate)
        {


            return 0;
        }

        public int CheckAlreadyHaveGSTEntry(string partyCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT ISNULL(COUNT(CREDNO),0) FROM PB.GSTOUTSTANDING  WHERE CREDNO='"+Convert.ToString(partyCode).Trim()+"'" ;
            int existingPartyCode = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql));
            return existingPartyCode;
        }

        public int CheckAlreadyHavePartyEntry(string partyCode,string partyCategory)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT ISNULL(COUNT(PARTYCODE),0) FROM PB.BENEFICIARYBANKS  WHERE PARTYCODE='" + Convert.ToString(partyCode).Trim() + "' AND PARTYTYPE='"+Convert.ToString(partyCategory).Trim()+"'";
            int existingPartyCode = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sql));
            return existingPartyCode;
        }


        public int AddGSTEntry(string partyCode,decimal gstAmount,int action)
        {
            int success;
            string _connectionString = SqlHelper.GetConnectionString();
            string sqlAdd = "INSERT INTO [PB].[GSTOUTSTANDING]([CREDNO],[AMOUNT])  VALUES ('" + Convert.ToString(partyCode).Trim() + "'," + Convert.ToString(gstAmount)+  ")";
            string sqlUpdate = "UPDATE PB.GSTOUTSTANDING SET AMOUNT=" + Convert.ToString(gstAmount) + " WHERE CREDNO='" + Convert.ToString(partyCode) + "'";

            if (action==0)
            {
                success = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sqlAdd));
            }
            else
            {
                success = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sqlUpdate));
            }
            return success;
        }

        public int AddPartyBankDetails(string partyCode,string partyName, string bankName, string branchName,string accountNumber,string IFSC,string beneficiaryName,string partyType , int action)
        {
            int success;
            string _connectionString = SqlHelper.GetConnectionString();
     
            string sqlAdd = "INSERT INTO [PB].[BENEFICIARYBANKS] ([PARTYCODE],[PARTYNAME],[PARTYTYPE],[BENEFICIARYNAME],[BENEFICIARYBANKACCOUNTNUMBER],[BANKNAME],[BRANCHNAME],[IFSCCODE]) VALUES (";
            sqlAdd = sqlAdd +"'"+ Convert.ToString(partyCode).Trim() + "','" + Convert.ToString(partyName).Trim() + "','"+Convert.ToString(partyType)+"','" + Convert.ToString(beneficiaryName).Trim() + "','" + Convert.ToString(accountNumber).Trim();
            sqlAdd = sqlAdd + "','" + Convert.ToString(bankName).Trim() + "','" + Convert.ToString(branchName).Trim() + "','" + Convert.ToString(IFSC).Trim() + "')";
            string sqlUpdate = "UPDATE [PB].[BENEFICIARYBANKS]    SET [PARTYNAME] = '" + Convert.ToString(partyName).Trim() + "',[BENEFICIARYNAME] = '" + Convert.ToString(beneficiaryName).Trim();
            sqlUpdate = sqlUpdate + "',[BENEFICIARYBANKACCOUNTNUMBER] = '" + Convert.ToString(accountNumber).Trim() + "',[BANKNAME] = '" + Convert.ToString(bankName).Trim() + "',[BRANCHNAME] = '";
            sqlUpdate = sqlUpdate + Convert.ToString(branchName).Trim() + "',[IFSCCODE] = '" + Convert.ToString(IFSC).Trim() + "' WHERE PARTYCODE ='" + Convert.ToString(partyCode) + "'";
 

            if (action == 0)
            {
                success = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sqlAdd));
            }
            else
            {
                success = Convert.ToInt16(SqlHelper.ExecuteScalar(_connectionString, CommandType.Text, sqlUpdate));
            }
            return success;
        }


        public DataSet GetGSTOutstanding()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT G.CREDNO PARTY,S.SUBNAME PARTYNAME ,G.AMOUNT FROM PB.GSTOUTSTANDING G INNER JOIN SUBCONTRACTORS S ON S.SUBNUMBER=G.CREDNO ORDER BY SUBNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet BeneficaryBankDetails()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT  PARTYTYPE, PARTYCODE, PARTYNAME, BANKNAME, BRANCHNAME,";
            sql = sql + " BENEFICIARYBANKACCOUNTNUMBER,IFSCCODE,BENEFICIARYNAME   FROM PB.BENEFICIARYBANKS ORDER BY PARTYTYPE, BANKNAME, BRANCHNAME,PARTYNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public int CheckHaveBankAccountDetails(string partyCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "SELECT ISNULL(COUNT(*),0) AS EXISTING FROM PB.BENEFICIARYBANKS WHERE PARTYCODE='" + Convert.ToString(partyCode).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, _sql);
            int k = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            return k;
        }

        public DataTable GetBankDetails(string clientCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            string sql = "SELECT COUNT(*) EXISTING FROM PB.PAYMENTBANKS B WHERE BANKREFERENCECODE='" + Convert.ToString(clientCode).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int existingBank = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (existingBank == 1)
            {
                sql = "SELECT  BANKID, BANKNAME, BANKACCOUNT, LEDGERCODE ";
                sql = sql + "  FROM PB.PAYMENTBANKS B WHERE B.BANKREFERENCECODE = '" + Convert.ToString(clientCode).Trim() + "'";
                ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
                DataTable dt = ds.Tables[0];
                return dt;
            }
            else
            {
                DataTable invalidBank = new DataTable("InvalidBank");
                invalidBank.Columns.Add(new DataColumn("BANKID", typeof(Int16)));
                invalidBank.Columns.Add(new DataColumn("BANKNAME", typeof(string)));
                invalidBank.Columns.Add(new DataColumn("BANKACCOUNT", typeof(string)));
                invalidBank.Columns.Add(new DataColumn("LEDGERCODE", typeof(string)));
                invalidBank.Rows.Add(0, "Unknown", "Unknown", "Unknown");
                return invalidBank;
            }
        }

       
        public DataTable GetPaymentDetails(string ifsc,string accountNumber, decimal amount)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT COUNT(*) EXISTING FROM PB.RTGSDETAIL RD WHERE RD.UTRNUMBER IS NULL AND  RD.BENEFICIARYACCOUNTNUMBER = '" + Convert.ToString(accountNumber).Trim();
            sql = sql + "' AND RD.IFSCCODE = '" + Convert.ToString(ifsc).Trim() + "' AND RD.PAYMENTAMOUNT = " + Convert.ToString(amount);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int existingParty = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (existingParty >=1)
            {
                sql = "SELECT TOP 1  1 AS VALID ,PBD.PARTYCODE,PBD.PARTYNAME,PBO.BSORGNAME,PBH.BATCHNO,RD.RTGSDETAILID,RD.UTRNUMBER ";
                sql = sql + " FROM   PB.RTGSDETAIL RD INNER JOIN PB.RTGSHEADER RH ON RH.RTGSID = RD.RTGSHeaderID INNER JOIN PB.PAYMENTBANKS PB ON PB.BANKID = RH.BANKID ";
                sql = sql + " INNER  JOIN PB.PAYMENTBATCHDETAIL PBD ON PBD.DETAILID = RD.BatchDetailID INNER JOIN PB.PAYMENTBATCHHEADER PBH ON PBH.BATCHID = PBD.BATCHID ";
                sql = sql + " INNER  JOIN PB.PAYMENTBATCHORGS PBO ON PBO.BSORGID = PBH.BATORGID WHERE RD.BENEFICIARYACCOUNTNUMBER = '";
                sql = sql + Convert.ToString(accountNumber) + "' AND RD.IFSCCODE = '" + Convert.ToString(ifsc) + "' AND RD.PAYMENTAMOUNT = " + Convert.ToString(amount);
                ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
                DataTable dt = ds.Tables[0];
                return dt;
            }
            else
            {
                DataTable invalidParty = new DataTable("InvalidParty");
                invalidParty.Columns.Add(new DataColumn("VALID", typeof(Int16)));
                invalidParty.Columns.Add(new DataColumn("PARTYCODE", typeof(string)));
                invalidParty.Columns.Add(new DataColumn("PARTYNAME", typeof(string)));
                invalidParty.Columns.Add(new DataColumn("BSORGNAME", typeof(string)));
                invalidParty.Columns.Add(new DataColumn("BATCHNO", typeof(string)));
                invalidParty.Columns.Add(new DataColumn("RTGSDETAILID", typeof(string)));
                invalidParty.Rows.Add(0, "Unknown", "Unknown", "Unknown", "Unknown", 0);
                return invalidParty;
                 
            }
        }

        public int UpdateUTRNumber(Int32 rtgsDetailID, string utrNumber) 
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string _sql = "UPDATE PB.RTGSDETAIL SET UTRNUMBER='" + Convert.ToString(utrNumber).Trim() + "'  WHERE RTGSDETAILID= " + Convert.ToString(rtgsDetailID);
            int k  = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, _sql);
            return k;
        }

    }
}

