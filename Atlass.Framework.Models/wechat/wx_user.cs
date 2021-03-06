//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models {

	public partial class wx_user {

		[JsonProperty,Column(IsPrimary =true)]
		public string id { get; set; }

		/// <summary>
		/// 患者openid
		/// </summary>
		public string open_id { get; set; }

		/// <summary>
		/// 昵称
		/// </summary>
		[JsonProperty]
		public string nick_name { get; set; } = string.Empty;
		/// <summary>
		/// 性别 0-女，1-男
		/// </summary>
		public int gender { get; set; }
		/// <summary>
		/// 出生年份
		/// </summary>
		public int birth_year { get; set; } 

		/// <summary>
		/// 职位
		/// </summary>
		[JsonProperty, Column(DbType = "varchar(50)")]
		public string job_name { get; set; } = string.Empty;
		/// <summary>
		/// 名族
		/// </summary>
		public string national { get; set; }
		/// <summary>
		/// 婚姻状况 1-未婚，2-已婚有配偶，3-离异或丧偶，4-不详
		/// </summary>
		public int marriage_status { get; set; }
		/// <summary>
		/// 文化程度，1-文盲，2-小学，3-初中，4-高中或中专,5-大专及以上
		/// </summary>
		public int educational_level { get; set; }
		/// <summary>
		/// 头像
		/// </summary>
		[JsonProperty]
		public string avatar_url { get; set; } = string.Empty;
		/// <summary>
		/// 时间
		/// </summary>

		[JsonProperty, Column(DbType = "datetime")]
		public DateTime create_time { get; set; }
		/// <summary>
		/// 省市
		/// </summary>
	    public string province { get; set; }
		public string city { get; set; }



	}

}
