﻿using JT809.Protocol.Formatters;
using JT809.Protocol.MessagePack;

namespace JT809.Protocol.Test.JT1078
{
    public class JT808_JT1078_0x1700_0x1701_Formatter : IJT809MessagePackFormatter<JT808_JT1078_0x1700_0x1701>
    {
        public JT808_JT1078_0x1700_0x1701 Deserialize(ref JT809MessagePackReader reader, IJT809Config config)
        {
            JT808_JT1078_0x1700_0x1701 jT808_JT1078_0X1701 = new JT808_JT1078_0x1700_0x1701();
            jT808_JT1078_0X1701.PlateFormId = reader.ReadArray(11).ToArray();
            jT808_JT1078_0X1701.AuthorizeCode1 = reader.ReadArray(64).ToArray();
            jT808_JT1078_0X1701.AuthorizeCode2 = reader.ReadArray(64).ToArray();
            return jT808_JT1078_0X1701;
        }

        public void Serialize(ref JT809MessagePackWriter writer, JT808_JT1078_0x1700_0x1701 value, IJT809Config config)
        {
            writer.WriteArray(value.PlateFormId);
            writer.WriteArray(value.AuthorizeCode1);
            writer.WriteArray(value.AuthorizeCode2);
        }
    }
}