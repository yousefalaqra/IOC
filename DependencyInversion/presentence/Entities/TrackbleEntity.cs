using System;

public class TrackbleEntity{
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string DeletedBy { get; set; }
    public DateTime DeletedOn { get; set; }
}