﻿using System;

namespace Cmm.Host.Model
{
    /// <summary>
    /// Событие с описанием.
    /// </summary>
    public class EventDescription
    {
        /// <summary>
        /// Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Время.
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Id устройства.
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// Описание события.
        /// </summary>
        public string Description { get; set; }
    }
}
