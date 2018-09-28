using System;

namespace Common
{
    public interface IEstructuraXml
    {
        string UblVersionId     { get; set; }
        string IdInvoice        { get; set; }
        IFormatProvider Formato { get; set; }
    }
}
