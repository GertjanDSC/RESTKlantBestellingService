﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_KlantBestelling.Model.Input {
    public class KlantRESTInputDTO {
        public int KlantId { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
    }
}
