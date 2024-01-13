﻿using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("LotoFacil")]
    [BsonIgnoreExtraElements]
    public class LotoFacilDocument : LoteriaDocument
    {
        public LotoFacilDocument(string loteria, int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(loteria, concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
