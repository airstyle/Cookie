//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.IO;
    
    
    public class PartyNameUpdateMessage : AbstractPartyMessage
    {
        
        public new const uint ProtocolId = 6502;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_partyName;
        
        public virtual string PartyName
        {
            get
            {
                return m_partyName;
            }
            set
            {
                m_partyName = value;
            }
        }
        
        public PartyNameUpdateMessage(string partyName)
        {
            m_partyName = partyName;
        }
        
        public PartyNameUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_partyName);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_partyName = reader.ReadUTF();
        }
    }
}