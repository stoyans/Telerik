using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class EncryptableDocuments : BinaryDocument, IEncryptable
{

    private bool isEncrypted = false;

    public EncryptableDocuments(string name = null, string content = null, int? size = null) :
        base(name, content, size)
    {
    }

    public virtual bool IsEncrypted
    {
        get { return this.isEncrypted; }
    }

    public virtual void Encrypt()
    {
        this.isEncrypted = true;
    }

    public virtual void Decrypt()
    {
        this.isEncrypted = false;
    }

    public override string ToString()
    {
        if (this.isEncrypted)
        {
            return String.Format("{0}[encrypted]", this.GetType().Name);
        }
        else
        {
            return base.ToString();
        }
    }

    public override void LoadProperty(string key, string value)
    {
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
    }
}

