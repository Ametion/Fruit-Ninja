namespace Model
{
    [System.Serializable]
    public class PauseData
    {
        public bool IsPause;

        public void SetDefoultValues() => IsPause = false;
    }
}