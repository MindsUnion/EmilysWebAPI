using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Reset_News_source_By_News
public void Reset_News_source_By_News(News i_News, List<News_source> i_News_source_List)
{
#region Declaration And Initialization Section.
Params_Delete_News_source_By_NEWS_ID oParams_Delete_News_source_By_NEWS_ID = new Params_Delete_News_source_By_NEWS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_News_source_By_News");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing News_source
//---------------------------------
oParams_Delete_News_source_By_NEWS_ID.NEWS_ID = i_News.NEWS_ID;
Delete_News_source_By_NEWS_ID(oParams_Delete_News_source_By_NEWS_ID);
//---------------------------------
// Edit News_source
//---------------------------------
Edit_News_WithNews_source(i_News, i_News_source_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_News_source_By_News");}
}
#endregion
#region Reset_News_source_By_News
public void Reset_News_source_By_News(News i_News, List<News_source> i_News_source_List_To_Delete,List<News_source> i_News_source_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_News_source oParams_Delete_News_source = new Params_Delete_News_source();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_News_source_By_News");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_News_source_List_To_Delete != null)
{
foreach (var oRow in i_News_source_List_To_Delete)
{
oParams_Delete_News_source.NEWS_SOURCE_ID = oRow.NEWS_SOURCE_ID;
Delete_News_source(oParams_Delete_News_source);
}
}
//---------------------------------
// Edit News_source
//---------------------------------
Edit_News_WithNews_source(i_News, i_News_source_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_News_source_By_News");}
}
#endregion
#region Edit_News_With_News_source(News i_News,List<News_source> i_News_sourceList)
public void Edit_News_WithNews_source(News i_News,List<News_source> i_List_News_source)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_News_WithNews_source");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_News(i_News);
if (i_List_News_source != null)
{
foreach(News_source oNews_source in i_List_News_source)
{
oNews_source.NEWS_ID = i_News.NEWS_ID;
Edit_News_source(oNews_source);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_News_WithNews_source");}
}
#endregion
#region Edit_News_WithRelatedData(News i_News,List<News_source> i_List_News_source)
public void Edit_News_WithRelatedData(News i_News,List<News_source> i_List_News_source)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_News_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_News(i_News);
if (i_List_News_source != null)
{
foreach(News_source oNews_source in i_List_News_source)
{
oNews_source.NEWS_ID = i_News.NEWS_ID;
Edit_News_source(oNews_source);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_News_WithRelatedData");}
}
#endregion
#region Delete_News_With_Children(News i_News)
public void Delete_News_With_Children(News i_News)
{
 #region Declaration And Initialization Section.
Params_Delete_News oParams_Delete_News = new Params_Delete_News();
Params_Delete_News_source_By_NEWS_ID oParams_Delete_News_source_By_NEWS_ID = new Params_Delete_News_source_By_NEWS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_News_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_News_source_By_NEWS_ID.NEWS_ID = i_News.NEWS_ID;
Delete_News_source_By_NEWS_ID(oParams_Delete_News_source_By_NEWS_ID);
//-------------------------

//-------------------------
oParams_Delete_News.NEWS_ID = i_News.NEWS_ID;
Delete_News(oParams_Delete_News);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_News_With_Children");}
}
#endregion
}
}
