namespace WebAppG5.ViewModel
{
    public class EmpWithColroBranchesTempMsgViewModel
    {
        //Some Model Propery With change NAme
        public int EmpID { get; set; }
        public string   EmpName { get; set; }

        //-----------Extran info
        public string Message { get; set; }
        public string Color { get; set; }
        public int Temp { get; set; }
        public List<string> Branches { get; set; }
    }
}
