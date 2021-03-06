//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild.Tax
{
    using Cookie.API.Utils.IO;
    using Cookie.API.Protocol.Network.Types.Game.Guild.Tax;


    public class TaxCollectorMovementAddMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5917;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private TaxCollectorInformations m_informations;
        
        public virtual TaxCollectorInformations Informations
        {
            get
            {
                return m_informations;
            }
            set
            {
                m_informations = value;
            }
        }
        
        public TaxCollectorMovementAddMessage(TaxCollectorInformations informations)
        {
            m_informations = informations;
        }
        
        public TaxCollectorMovementAddMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_informations.TypeID)));
            m_informations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_informations = ProtocolTypeManager.GetInstance<TaxCollectorInformations>((short)reader.ReadUShort());
            m_informations.Deserialize(reader);
        }
    }
}
