namespace LB8_2;

public class VolumeExceededException:Exception
{
    public VolumeExceededException(string message) : base(message) { }
}