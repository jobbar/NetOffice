﻿using System;
using NetOffice;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 12, 14
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863185(v=office.14).aspx </remarks>
	[SupportByVersionAttribute("MSProject", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjYesNoAutomatic
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjNo = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjYes = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjAuto = 2
	}
}