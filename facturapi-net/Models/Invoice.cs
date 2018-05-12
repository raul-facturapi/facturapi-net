﻿using Facturapi.Wrappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturapi
{
    public class Invoice
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Livemode { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public Decimal Total { get; set; }
        public string Uuid { get; set; }
        public long FolioNumber { get; set; }
        public string Series { get; set; }
        public string PaymentForm { get; set; }
        public List<InvoiceItem> Items { get; set; }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task<SearchResult<Invoice>> ListAsync(Dictionary<string, object> query = null)
        {
            return new InvoiceWrapper().ListAsync(query);
        }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task<Invoice> CreateAsync(Dictionary<string, object> data)
        {
            return new InvoiceWrapper().CreateAsync(data);
        }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task<Invoice> RetrieveAsync(string id)
        {
            return new InvoiceWrapper().RetrieveAsync(id);
        }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task<Invoice> CancelAsync(string id)
        {
            return new InvoiceWrapper().CancelAsync(id);
        }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task SendByEmailAsync(string id)
        {
            return new InvoiceWrapper().SendByEmailAsync(id);
        }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task<Stream> DownloadXmlAsync(string id)
        {
            return new InvoiceWrapper().DownloadXmlAsync(id);
        }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task<Stream> DownloadPdfAsync(string id)
        {
            return new InvoiceWrapper().DownloadPdfAsync(id);
        }

        [Obsolete("Methods requiring you to set ApiKeys globally are deprecated and will be removed in the next major release. Use methods from the Facturapi.Wrapper instance instead.")]
        public static Task<Stream> DownloadZipAsync(string id)
        {
            return new InvoiceWrapper().DownloadZipAsync(id);
        }
    }
}
