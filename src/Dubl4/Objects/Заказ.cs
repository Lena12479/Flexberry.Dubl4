﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Dubl4
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Заказ.
    /// </summary>
    // *** Start programmer edit section *** (Заказ CustomAttributes)

    // *** End programmer edit section *** (Заказ CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаказE", new string[] {
            "Дата as \'Дата\'",
            "ТипОплаты as \'Тип оплаты\'"})]
    [View("ЗаказL", new string[] {
            "Дата as \'Дата\'",
            "ТипОплаты as \'Тип оплаты\'"})]
    public class Заказ : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата = System.DateTime.Now;
        
        private IIS.Dubl4.Оплата fТипОплаты;
        
        // *** Start programmer edit section *** (Заказ CustomMembers)

        // *** End programmer edit section *** (Заказ CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Дата CustomAttributes)

        // *** End programmer edit section *** (Заказ.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Дата Get start)

                // *** End programmer edit section *** (Заказ.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Заказ.Дата Get end)

                // *** End programmer edit section *** (Заказ.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Дата Set start)

                // *** End programmer edit section *** (Заказ.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Заказ.Дата Set end)

                // *** End programmer edit section *** (Заказ.Дата Set end)
            }
        }
        
        /// <summary>
        /// ТипОплаты.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.ТипОплаты CustomAttributes)

        // *** End programmer edit section *** (Заказ.ТипОплаты CustomAttributes)
        public virtual IIS.Dubl4.Оплата ТипОплаты
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.ТипОплаты Get start)

                // *** End programmer edit section *** (Заказ.ТипОплаты Get start)
                IIS.Dubl4.Оплата result = this.fТипОплаты;
                // *** Start programmer edit section *** (Заказ.ТипОплаты Get end)

                // *** End programmer edit section *** (Заказ.ТипОплаты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.ТипОплаты Set start)

                // *** End programmer edit section *** (Заказ.ТипОплаты Set start)
                this.fТипОплаты = value;
                // *** Start programmer edit section *** (Заказ.ТипОплаты Set end)

                // *** End programmer edit section *** (Заказ.ТипОплаты Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаказE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказE", typeof(IIS.Dubl4.Заказ));
                }
            }
            
            /// <summary>
            /// "ЗаказL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказL", typeof(IIS.Dubl4.Заказ));
                }
            }
        }
    }
}
