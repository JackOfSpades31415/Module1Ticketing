public class ticketFile {

    public string filePath { get; set;}
    public List<Ticket> Tickets {get; set;}

    public ticketFile(string ticketFilePath){
        filePath = ticketFilePath;
        Tickets = new List<Ticket>();

        StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
                Ticket ticket = new Ticket();
                string line = sr.ReadLine();
                    string[] ticketInfo = line.Split(',');
                    ticket.ticketID = UInt64.Parse(ticketInfo[0]);
                    ticket.summary = ticketInfo[1];
                    ticket.status = ticketInfo[2];
                    ticket.priority = ticketInfo[3];
                    ticket.submitter = ticketInfo[4];
                    ticket.assigned = ticketInfo[5];
                    ticket.watching = ticketInfo[6];
                    Tickets.Add(ticket);
            }
            sr.Close();
            
    }

    

}