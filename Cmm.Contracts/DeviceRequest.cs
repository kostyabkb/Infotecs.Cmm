﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cmm.Contracts
{
    /// <summary>
    /// Устройство, присылаемая статистика.
    /// </summary>
    public class DeviceRequest
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// ОС.
        /// </summary>
        [Required]
        [StringLength(64)]
        public string Os { get; set; }

        /// <summary>
        /// Версия.
        /// </summary>
        [Required]
        [StringLength(64)]
        public string Version { get; set; }

        /// <summary>
        /// События.
        /// </summary>
        public List<DeviceEventRequest> DeviceEvents { get; set; }
    }
}
