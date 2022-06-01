namespace ddddocrsharp
{
    public class DetResult
    {

        public float x1 { get; set; }
        public float y1 { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }

        public float Score { get; set; }


        public DetResult(float confidence, float x1, float y1, float x2, float y2)
        {
            Score = confidence;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

        }

    }
}
