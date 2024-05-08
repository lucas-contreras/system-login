namespace System.Login.Entity
{
    public class GlobalConfig
    {
        public int Id { get; set; }
        public short AttemptsToLogin { get; set; }
        public bool CheckMinCharacters { get; set; }
        public bool RequireMayusAndMin { get; set; }
        public bool RequireNumberAndChars { get; set; }
        public bool RequireAtLeastOneSpecialChar { get; set; }
        public bool Require2FAAuth { get; set; }
        public bool RequireSecurtyQuestions { get; set; }
        public bool AllowOldPassCombination { get; set; }
        public bool AllowAutoUnlockUser { get; set; }
        public DateTime? UnlockLapseTime { get; set; }
    }
}
