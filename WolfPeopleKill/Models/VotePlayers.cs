﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WolfPeopleKill.Models
{
    public class VotePlayers
    {
        /// <summary>
        /// 房間ID
        /// </summary>
        [Required]
        public int RoomID { get; set; }
        /// <summary>
        /// 玩家帳號
        /// </summary>
        [Required]
        public string User { get; set; }

        /// <summary>
        /// 投票對象號碼
        /// </summary>
        [Required]
        public string Vote { get; set; }

        /// <summary>
        /// 得票數
        /// </summary>
        public int VoteTickets { get; set; }

        /// <summary>
        /// 投票結果
        /// </summary>
        public string voteResult { get; set; }
    }
}
