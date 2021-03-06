namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Tajikistan
    /// </summary>
    public class TajikistanInfo : ICountryInfo
    {
        public string CommonName => "Tajikistan";
        public string OfficialName => "Republic of Tajikistan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "طاجيكستان"),
            new Translation(LanguageCode.AZ, "Tacikistan"),
            new Translation(LanguageCode.BE, "Таджыкістан"),
            new Translation(LanguageCode.BG, "Таджикистан"),
            new Translation(LanguageCode.BS, "Tadžikistan"),
            new Translation(LanguageCode.CA, "Tadjikistan"),
            new Translation(LanguageCode.CS, "Tádžikistán"),
            new Translation(LanguageCode.DA, "Tadsjikistan"),
            new Translation(LanguageCode.DE, "Tadschikistan"),
            new Translation(LanguageCode.EL, "Τατζικιστάν"),
            new Translation(LanguageCode.EN, "Tajikistan"),
            new Translation(LanguageCode.ES, "Tayikistán"),
            new Translation(LanguageCode.ET, "Tadžikistan"),
            new Translation(LanguageCode.FA, "تاجیکستان"),
            new Translation(LanguageCode.FI, "Tadžikistan"),
            new Translation(LanguageCode.FR, "Tadjikistan"),
            new Translation(LanguageCode.HE, "טג׳יקיסטן"),
            new Translation(LanguageCode.HR, "Tadžikistan"),
            new Translation(LanguageCode.HU, "Tádzsikisztán"),
            new Translation(LanguageCode.HY, "Տաջիկստան"),
            new Translation(LanguageCode.ID, "Tajikistan"),
            new Translation(LanguageCode.IT, "Tagikistan"),
            new Translation(LanguageCode.JA, "タジキスタン"),
            new Translation(LanguageCode.KA, "ტაჯიკეთი"),
            new Translation(LanguageCode.KK, "Тәжікстан"),
            new Translation(LanguageCode.KO, "타지키스탄"),
            new Translation(LanguageCode.KY, "Тажикстан"),
            new Translation(LanguageCode.LT, "Tadžikija"),
            new Translation(LanguageCode.LV, "Tadžikistāna"),
            new Translation(LanguageCode.MK, "Таџикистан"),
            new Translation(LanguageCode.MN, "Тажикистан"),
            new Translation(LanguageCode.NB, "Tadsjikistan"),
            new Translation(LanguageCode.NL, "Tadzjikistan"),
            new Translation(LanguageCode.NN, "Tadsjikistan"),
            new Translation(LanguageCode.PL, "Tadżykistan"),
            new Translation(LanguageCode.PT, "Tajiquistão"),
            new Translation(LanguageCode.RO, "Tadjikistan"),
            new Translation(LanguageCode.RU, "Таджикистан"),
            new Translation(LanguageCode.SK, "Tadžikistan"),
            new Translation(LanguageCode.SL, "Tadžikistan"),
            new Translation(LanguageCode.SR, "Таџикистан"),
            new Translation(LanguageCode.SV, "Tadzjikistan"),
            new Translation(LanguageCode.TR, "Tacikistan"),
            new Translation(LanguageCode.UK, "Таджикистан"),
            new Translation(LanguageCode.UZ, "Tojikiston"),
            new Translation(LanguageCode.ZH, "塔吉克斯坦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TJ;
        public Alpha3Code Alpha3Code => Alpha3Code.TJK;
        public int NumericCode => 762;
        public string[] TLD => new [] { ".tj" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.CN,
            Alpha2Code.KG,
            Alpha2Code.UZ,
        };

        public string[] Currencies => new [] { "TJS" };
        public string[] CallingCodes => new [] { "992" };
    }
}
