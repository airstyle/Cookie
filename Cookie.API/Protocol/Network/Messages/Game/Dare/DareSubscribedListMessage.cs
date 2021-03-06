//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Dare
{
    using Cookie.API.Protocol.Network.Types.Game.Dare;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class DareSubscribedListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6658;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<DareInformations> m_daresFixedInfos;
        
        public virtual List<DareInformations> DaresFixedInfos
        {
            get
            {
                return m_daresFixedInfos;
            }
            set
            {
                m_daresFixedInfos = value;
            }
        }
        
        private List<DareVersatileInformations> m_daresVersatilesInfos;
        
        public virtual List<DareVersatileInformations> DaresVersatilesInfos
        {
            get
            {
                return m_daresVersatilesInfos;
            }
            set
            {
                m_daresVersatilesInfos = value;
            }
        }
        
        public DareSubscribedListMessage(List<DareInformations> daresFixedInfos, List<DareVersatileInformations> daresVersatilesInfos)
        {
            m_daresFixedInfos = daresFixedInfos;
            m_daresVersatilesInfos = daresVersatilesInfos;
        }
        
        public DareSubscribedListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_daresFixedInfos.Count)));
            int daresFixedInfosIndex;
            for (daresFixedInfosIndex = 0; (daresFixedInfosIndex < m_daresFixedInfos.Count); daresFixedInfosIndex = (daresFixedInfosIndex + 1))
            {
                DareInformations objectToSend = m_daresFixedInfos[daresFixedInfosIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_daresVersatilesInfos.Count)));
            int daresVersatilesInfosIndex;
            for (daresVersatilesInfosIndex = 0; (daresVersatilesInfosIndex < m_daresVersatilesInfos.Count); daresVersatilesInfosIndex = (daresVersatilesInfosIndex + 1))
            {
                DareVersatileInformations objectToSend = m_daresVersatilesInfos[daresVersatilesInfosIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int daresFixedInfosCount = reader.ReadUShort();
            int daresFixedInfosIndex;
            m_daresFixedInfos = new System.Collections.Generic.List<DareInformations>();
            for (daresFixedInfosIndex = 0; (daresFixedInfosIndex < daresFixedInfosCount); daresFixedInfosIndex = (daresFixedInfosIndex + 1))
            {
                DareInformations objectToAdd = new DareInformations();
                objectToAdd.Deserialize(reader);
                m_daresFixedInfos.Add(objectToAdd);
            }
            int daresVersatilesInfosCount = reader.ReadUShort();
            int daresVersatilesInfosIndex;
            m_daresVersatilesInfos = new System.Collections.Generic.List<DareVersatileInformations>();
            for (daresVersatilesInfosIndex = 0; (daresVersatilesInfosIndex < daresVersatilesInfosCount); daresVersatilesInfosIndex = (daresVersatilesInfosIndex + 1))
            {
                DareVersatileInformations objectToAdd = new DareVersatileInformations();
                objectToAdd.Deserialize(reader);
                m_daresVersatilesInfos.Add(objectToAdd);
            }
        }
    }
}
