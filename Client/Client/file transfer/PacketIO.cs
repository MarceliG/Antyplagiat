using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
public class PacketWriter : BinaryWriter
{
    private readonly MemoryStream ms;
    private readonly BinaryFormatter bf;

    public PacketWriter()
        : base()
    {
        ms = new MemoryStream();
        bf = new BinaryFormatter();
        OutStream = ms;
    }

    public void Write(Image image)
    {
        var ms = new MemoryStream();

        image.Save(ms, ImageFormat.Png);

        ms.Close();

        byte[] imageBytes = ms.ToArray();

        Write(imageBytes.Length);
        Write(imageBytes);
    }

    public void WriteT(object obj)
    {
        bf.Serialize(ms, obj);
    }

    public byte[] GetBytes()
    {
        Close();

        byte[] data = ms.ToArray();

        return data;
    }
}

public class PacketReader : BinaryReader
{
    private readonly BinaryFormatter bf;
    public PacketReader(byte[] data)
        : base(new MemoryStream(data))
    {
        bf = new BinaryFormatter();
    }

    public Image ReadImage()
    {
        int len = ReadInt32();

        byte[] bytes = ReadBytes(len);

        Image img;

        using (MemoryStream ms = new MemoryStream(bytes))
        {
            img = Image.FromStream(ms);
        }

        return img;
    }

    public T ReadObject<T>()
    {
        return (T)bf.Deserialize(BaseStream);
    }
}