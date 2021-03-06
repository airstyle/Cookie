//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild
{
    using Cookie.API.Protocol.Network.Types.Game.House;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildHouseUpdateInformationMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6181;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private HouseInformationsForGuild m_housesInformations;
        
        public virtual HouseInformationsForGuild HousesInformations
        {
            get
            {
                return m_housesInformations;
            }
            set
            {
                m_housesInformations = value;
            }
        }
        
        public GuildHouseUpdateInformationMessage(HouseInformationsForGuild housesInformations)
        {
            m_housesInformations = housesInformations;
        }
        
        public GuildHouseUpdateInformationMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_housesInformations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_housesInformations = new HouseInformationsForGuild();
            m_housesInformations.Deserialize(reader);
        }
    }
}
