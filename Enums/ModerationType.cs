



using System.ComponentModel;

namespace TheBlog2023.Enums
{
    public enum ModerationType
    {

        [Description("Political propaganda")]
        Political,
        [Description("Offensive language")]
        Language,
        [Description("Drug references")]
        Drugs,
        [Description("Threating speech")]
        Threatening,
        [Description("Sexual content")]
        Sexual,
        [Description("Hate speech")]
        HateSpeech,
        [Description("Targeted shaming")]
        Shaming
    }
}
