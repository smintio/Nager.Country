namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Greece
    /// </summary>
    public class GreeceInfo : ICountryInfo
    {
        public string CommonName => "Greece";
        public string OfficialName => "Hellenic Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "اليونان"),
            new Translation(LanguageCode.AZ, "Yunanıstan"),
            new Translation(LanguageCode.BE, "Грэцыя"),
            new Translation(LanguageCode.BG, "Гърция"),
            new Translation(LanguageCode.BS, "Grčka"),
            new Translation(LanguageCode.CA, "Grècia"),
            new Translation(LanguageCode.CS, "Řecko"),
            new Translation(LanguageCode.DA, "Grækenland"),
            new Translation(LanguageCode.DE, "Griechenland"),
            new Translation(LanguageCode.EL, "Ελλάδα"),
            new Translation(LanguageCode.EN, "Greece"),
            new Translation(LanguageCode.ES, "Grecia"),
            new Translation(LanguageCode.ET, "Kreeka"),
            new Translation(LanguageCode.FA, "یونان"),
            new Translation(LanguageCode.FI, "Kreikka"),
            new Translation(LanguageCode.FR, "Grèce"),
            new Translation(LanguageCode.HE, "יוון"),
            new Translation(LanguageCode.HR, "Grčka"),
            new Translation(LanguageCode.HU, "Görögország"),
            new Translation(LanguageCode.HY, "Հունաստան"),
            new Translation(LanguageCode.ID, "Yunani"),
            new Translation(LanguageCode.IT, "Grecia"),
            new Translation(LanguageCode.JA, "ギリシャ"),
            new Translation(LanguageCode.KA, "საბერძნეთი"),
            new Translation(LanguageCode.KK, "Грекия"),
            new Translation(LanguageCode.KO, "그리스"),
            new Translation(LanguageCode.KY, "Греция"),
            new Translation(LanguageCode.LT, "Graikija"),
            new Translation(LanguageCode.LV, "Grieķija"),
            new Translation(LanguageCode.MK, "Грција"),
            new Translation(LanguageCode.MN, "Грек"),
            new Translation(LanguageCode.NB, "Hellas"),
            new Translation(LanguageCode.NL, "Griekenland"),
            new Translation(LanguageCode.NN, "Hellas"),
            new Translation(LanguageCode.PL, "Grecja"),
            new Translation(LanguageCode.PT, "Grécia"),
            new Translation(LanguageCode.RO, "Grecia"),
            new Translation(LanguageCode.RU, "Греция"),
            new Translation(LanguageCode.SK, "Grécko"),
            new Translation(LanguageCode.SL, "Grčija"),
            new Translation(LanguageCode.SR, "Грчка"),
            new Translation(LanguageCode.SV, "Grekland"),
            new Translation(LanguageCode.TR, "Yunanistan"),
            new Translation(LanguageCode.UK, "Греція"),
            new Translation(LanguageCode.UZ, "Gretsiya"),
            new Translation(LanguageCode.ZH, "希腊"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GR;
        public Alpha3Code Alpha3Code => Alpha3Code.GRC;
        public int NumericCode => 300;
        public string[] TLD => new [] { ".gr" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AL,
            Alpha2Code.BG,
            Alpha2Code.TR,
            Alpha2Code.MK,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "30" };
    }
}
