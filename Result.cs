namespace Define
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Result
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("phonetic")]
        public string Phonetic { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("meanings")]
        public List<Meaning> Meanings { get; set; }
    }

    public partial class Meaning
    {
        [JsonProperty("partOfSpeech")]
        public string PartOfSpeech { get; set; }

        [JsonProperty("definitions")]
        public List<Definition> Definitions { get; set; }
    }

    public partial class Definition
    {
        [JsonProperty("definition")]
        public string DefinitionDefinition { get; set; }

        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public string Example { get; set; }

        [JsonProperty("synonyms", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Synonyms { get; set; }
    }
}
