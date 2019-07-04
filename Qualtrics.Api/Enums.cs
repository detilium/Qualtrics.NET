using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api
{
    public enum Type
    {
        Trial
    }

    public enum Status
    {
        Active
    }

    public enum AccountStatus
    {
        Active
    }

    public enum Formats
    {
        [Description("csv")]
        CSV,

        [Description("tsv")]
        TSV,

        [Description("spss")]
        SPSS,

        [Description("json")]
        JSON,

        [Description("ndjson")]
        NDJSON
    }

    public enum TimeZones
    {
        [Description("Pacific/Midway")]
        Pacific_Midway,

        [Description("Pacific/Honolulu")]
        Pacific_Honolulu,

        [Description("America/Anchorage")]
        America_Anchorage,

        [Description("America/Los_Angeles")]
        America_Los_Angeles,

        [Description("America/Phoenix")]
        America_Phoenix,

        [Description("America/Denver")]
        America_Denver,

        [Description("America/Chicago")]
        America_Chicago,

        [Description("America/Rio_Branco")]
        America_Rop_Branco,

        [Description("America/New_York")]
        America_New_York,

        [Description("America/La_Paz")]
        America_La_Paz,

        [Description("America/Montevideo")]
        America_Montevideo,

        [Description("America/Argentina/Buenos_Aires")]
        America_Argentina_Buenos_Aires,

        [Description("America/Noronha")]
        America_Noronha,

        [Description("Canada/East-Saskatchewan")]
        Canada_East_Saskatchewan,

        [Description("Canada/Atlantic")]
        Canada_Atalantic,

        [Description("Canada/Newfoundland")]
        Canada_Newfoundland,

        [Description("Atlantic/Azores")]
        Atlanatic_Azores,

        [Description("Atlantic/Cape_Verde")]
        Atlantic_Cape_Verde,

        [Description("Atlantic/Reykjavik")]
        Atlantic_Reykjavik,

        [Description("Europe/London")]
        Europe_London,

        [Description("Europe/Berlin")]
        Europe_Berlin,

        [Description("Europe/Athens")]
        Europe_Athens,

        [Description("Europe/Moscow")]
        Europe_Moscow,

        [Description("Africa/Bangui")]
        Africa_Bangui,

        [Description("Africa/Harare")]
        Africa_Harare,

        [Description("Africa/Nairobi")]
        Africa_Nairobi,

        [Description("Asia/Tehran")]
        Asia_Tehran,

        [Description("Asia/Muscat")]
        Asia_Muscat,

        [Description("Asia/Baku")]
        Asia_Baku,

        [Description("Asia/Kabul")]
        Asia_Kabul,

        [Description("Asia/Yekaterinburg")]
        Asia_Yekaterinburg,

        [Description("Asia/Karachi")]
        Asia_Karachi,

        [Description("Asia/Calcutta")]
        Asia_Calcutta,

        [Description("Asia/Katmandu")]
        Asia_Katmandu,

        [Description("Asia/Dhaka")]
        Asia_Dhaka,

        [Description("Asia/Novosibirsk")]
        Asia_Novosibirsk,

        [Description("Asia/Rangoon")]
        Asia_Rangoon,

        [Description("Asia/Krasnoyk")]
        Asia_Krasnoyk,

        [Description("Asia/Yakutsk")]
        Asia_Yakutsk,

        [Description("Asia/Seoul")]
        Asia_Seoul,

        [Description("Asia/Bangkorwin")]
        Asia_Bangkorwin,

        [Description("Asia/Magadan")]
        Asia_Magadan,

        [Description("Australia/Daarsk")]
        Austraila_Daarsk,

        [Description("Australia/Adelaide")]
        Austraila_Adelaide,

        [Description("Australia/Brisbane")]
        Austraila_Brisbane,

        [Description("Australia/Canberra")]
        Austraila_Canberra,

        [Description("Pacific/Auckland")]
        Pacific_Auckland,

        [Description("Pacific/Fiji")]
        Pacific_Fiji,

        [Description("Pacific/Tongatapu")]
        Pacific_Tongatapu
    }

    public enum GraphicContentType
    {
        [Description("image/jpeg")]
        JPEG,

        [Description("image/gif")]
        GIF,

        [Description("image/png")]
        PNG
    }

    public enum ContactHistoryType
    {
        [Description("email")]
        Email,

        [Description("response")]
        Response
    }

    public enum SearchFilterComparison
    {
        [Description("eq")]
        Eq
    }

    public enum SearchFilterConjunction
    {
        [Description("and")]
        And,

        [Description("or")]
        Or
    }
}
