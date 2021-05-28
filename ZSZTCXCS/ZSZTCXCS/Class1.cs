

//k5c6665d521cc418895cc716bf5ae9739
//F_PAEZ_Text2

using System;
using System.Collections.Generic;
using System.Text;
using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.DynamicForm;
using Kingdee.BOS.Core.DynamicForm.PlugIn.Args;
using Kingdee.BOS.Orm.DataEntity;
using Kingdee.BOS.Core.Metadata.EntityElement;
using Kingdee.BOS;
using Kingdee.K3.MFG.App;
using System.Linq;
using Kingdee.BOS.Util;
using System.Data;
using Kingdee.BOS.Core.Metadata;
using Kingdee.BOS.Core.Metadata.FieldElement;
using Kingdee.BOS.Core.DynamicForm.PlugIn.ControlModel;
using Kingdee.BOS.Core.Bill;
using Kingdee.K3.SCM.ServiceHelper;
using Kingdee.BOS.Core.List;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace JMT_SCDDPLXGRQ
{
    public class JMT_SCDDPLXGRQ : AbstractBillPlugIn      // 表单插件   生产订单批量修改日期
    {
        public object MetaDataServiceHelper { get; private set; }
        public IDynamicFormViewService billView { get; private set; }
        public int DD { get; private set; }



        public void testc(DataSet ds222, int i, int j, int spec1)
        {
            if (ds222.Tables[0].Rows[i]["FFLEX4"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX4"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX4"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX4"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX4", ds222.Tables[0].Rows[i]["FFLEX4"].ToString(), j);
            }
            if (ds222.Tables[0].Rows[i]["FFLEX5"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX5"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX5"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX5"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), j);
            }
            if (ds222.Tables[0].Rows[i]["FFLEX6"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX6"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX6"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX6"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX6", ds222.Tables[0].Rows[i]["FFLEX6"].ToString(), j);
            }
            if (ds222.Tables[0].Rows[i]["FFLEX7"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX7"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX7"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX7"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX7", ds222.Tables[0].Rows[i]["FFLEX7"].ToString(), j);
            }
            if (ds222.Tables[0].Rows[i]["FFLEX8"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX8"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX8"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX8"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX8", ds222.Tables[0].Rows[i][20].ToString(), j);
            }
            if (spec1 == 1)
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX9", 102241, j);
            }
            else
            {
                if (ds222.Tables[0].Rows[i]["FFLEX9"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX9"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX9"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX9"].ToString() != " ")
                {
                    this.View.Model.SetValue("$$FDetailID__FFLEX9", ds222.Tables[0].Rows[i]["FFLEX9"].ToString(), j);
                }
            }

            if (ds222.Tables[0].Rows[i]["FFLEX10"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX10"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX10"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX10"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX10", ds222.Tables[0].Rows[i]["FFLEX10"].ToString(), j);
            }
            if (ds222.Tables[0].Rows[i]["FFLEX11"].ToString() != null && ds222.Tables[0].Rows[i]["FFLEX11"].ToString() != "" && ds222.Tables[0].Rows[i]["FFLEX11"].ToString() != "0" && ds222.Tables[0].Rows[i]["FFLEX11"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX11", ds222.Tables[0].Rows[i]["FFLEX11"].ToString(), j);
            }
            if (spec1 == 1)
            {
                this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", j);
            }
            else
            {
                if (ds222.Tables[0].Rows[i]["FF100002"].ToString() != null && ds222.Tables[0].Rows[i]["FF100002"].ToString() != "" && ds222.Tables[0].Rows[i]["FF100002"].ToString() != "0" && ds222.Tables[0].Rows[i]["FF100002"].ToString() != " ")
                {
                    this.View.Model.SetValue("$$FDetailID__FF100002", ds222.Tables[0].Rows[i]["FF100002"].ToString(), j);

                }
            }

            if (ds222.Tables[0].Rows[i]["FF100003"].ToString() != null && ds222.Tables[0].Rows[i]["FF100003"].ToString() != "" && ds222.Tables[0].Rows[i]["FF100003"].ToString() != "0" && ds222.Tables[0].Rows[i]["FF100003"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), j);
            }
            this.View.InvokeFieldUpdateService("FDetailID", j);

        }
        public void testu(DataSet ds225, int i, int j, int spec1)
        {
            if (ds225.Tables[0].Rows[i]["FFLEX4"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX4"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX4"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX4"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX4", ds225.Tables[0].Rows[i]["FFLEX4"].ToString(), j);
            }
            if (ds225.Tables[0].Rows[i]["FFLEX5"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX5"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX5"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX5"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX5", ds225.Tables[0].Rows[i]["FFLEX5"].ToString(), j);
            }
            if (ds225.Tables[0].Rows[i]["FFLEX6"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX6"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX6"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX6"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX6", ds225.Tables[0].Rows[i]["FFLEX6"].ToString(), j);
            }
            if (ds225.Tables[0].Rows[i]["FFLEX7"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX7"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX7"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX7"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX7", ds225.Tables[0].Rows[i]["FFLEX7"].ToString(), j);
            }
            if (ds225.Tables[0].Rows[i]["FFLEX8"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX8"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX8"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX8"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX8", ds225.Tables[0].Rows[i][20].ToString(), j);
            }
            if (spec1 == 1)
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX9", 102241, j);
            }
            else
            {
                if (ds225.Tables[0].Rows[i]["FFLEX9"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX9"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX9"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX9"].ToString() != " ")
                {
                    this.View.Model.SetValue("$$FDetailID__FFLEX9", ds225.Tables[0].Rows[i]["FFLEX9"].ToString(), j);
                }
            }

            if (ds225.Tables[0].Rows[i]["FFLEX10"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX10"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX10"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX10"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX10", ds225.Tables[0].Rows[i]["FFLEX10"].ToString(), j);
            }
            if (ds225.Tables[0].Rows[i]["FFLEX11"].ToString() != null && ds225.Tables[0].Rows[i]["FFLEX11"].ToString() != "" && ds225.Tables[0].Rows[i]["FFLEX11"].ToString() != "0" && ds225.Tables[0].Rows[i]["FFLEX11"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX11", ds225.Tables[0].Rows[i]["FFLEX11"].ToString(), j);
            }
            if (spec1 == 1)
            {
                this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", j);
            }
            else
            {
                if (ds225.Tables[0].Rows[i]["FF100002"].ToString() != null && ds225.Tables[0].Rows[i]["FF100002"].ToString() != "" && ds225.Tables[0].Rows[i]["FF100002"].ToString() != "0" && ds225.Tables[0].Rows[i]["FF100002"].ToString() != " ")
                {
                    this.View.Model.SetValue("$$FDetailID__FF100002", ds225.Tables[0].Rows[i]["FF100002"].ToString(), j);

                }
            }

            if (ds225.Tables[0].Rows[i]["FF100003"].ToString() != null && ds225.Tables[0].Rows[i]["FF100003"].ToString() != "" && ds225.Tables[0].Rows[i]["FF100003"].ToString() != "0" && ds225.Tables[0].Rows[i]["FF100003"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FF100003", ds225.Tables[0].Rows[i]["FF100003"].ToString(), j);
            }
            this.View.InvokeFieldUpdateService("FDetailID", j);

        }
        public void testb(DataSet ds224, int i, int j, int spec1)
        {

            if (ds224.Tables[0].Rows[i]["FFLEX5"].ToString() != null && ds224.Tables[0].Rows[i]["FFLEX5"].ToString() != "" && ds224.Tables[0].Rows[i]["FFLEX5"].ToString() != "0" && ds224.Tables[0].Rows[i]["FFLEX5"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FFLEX5", ds224.Tables[0].Rows[i]["FFLEX5"].ToString(), j);
            }

            if (spec1 == 1)
            {
                this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", j);
            }
            else
            {
                if (ds224.Tables[0].Rows[i]["FF100002"].ToString() != null && ds224.Tables[0].Rows[i]["FF100002"].ToString() != "" && ds224.Tables[0].Rows[i]["FF100002"].ToString() != "0" && ds224.Tables[0].Rows[i]["FF100002"].ToString() != " ")
                {
                    this.View.Model.SetValue("$$FDetailID__FF100002", ds224.Tables[0].Rows[i]["FF100002"].ToString(), j);

                }
            }

            if (ds224.Tables[0].Rows[i]["FF100003"].ToString() != null && ds224.Tables[0].Rows[i]["FF100003"].ToString() != "" && ds224.Tables[0].Rows[i]["FF100003"].ToString() != "0" && ds224.Tables[0].Rows[i]["FF100003"].ToString() != " ")
            {
                this.View.Model.SetValue("$$FDetailID__FF100003", ds224.Tables[0].Rows[i]["FF100003"].ToString(), j);
            }
            this.View.InvokeFieldUpdateService("FDetailID", j);

        }

        public override void BarItemClick(BarItemClickEventArgs e)
        {
            base.BarItemClick(e);
            if (e.BarItemKey == "tbButton") //点击获取生产订单
            {




                ListSelBillShowParameter parameter = new ListSelBillShowParameter();//弹出列表 有返回数据按钮
                parameter.FormId = "k2df3f8419d564c58bf4708a5d8de0c5c";// 单据标识 
                parameter.MultiSelect = true;  //允许多选
                parameter.IsShowApproved = true;  //显示审核




                ////先清除单据体 
                //EntryEntity entity = this.View.BusinessInfo.GetEntryEntity("F_ZCZC_Entity");
                //DynamicObjectCollection entryDatas = this.View.Model.GetEntityDataObject(entity);
                //List<DynamicObject> deleteEntryDatas = new List<DynamicObject>();
                //deleteEntryDatas = entryDatas.ToList();
                //foreach (DynamicObject entryData in deleteEntryDatas)
                //{

                //    this.View.Model.DeleteEntryRow("F_ZCZC_Entity", entryDatas.IndexOf(entryData));//删除单据体

                //}


                //然后在根据选择的数据给单据体赋值
                this.View.ShowForm(parameter, new Action<FormResult>((result) =>
                {
                    if (result != null && result.ReturnData != null && (result.ReturnData as ListSelectedRowCollection).Count > 0)
                    {
                        String djbh = "";
                        StringBuilder sb2 = new StringBuilder();
                        DataSet ds222 = new DataSet();
                        StringBuilder sb222 = new StringBuilder();

                        if ((result.ReturnData as ListSelectedRowCollection).Count == 1)
                        {
                            djbh = "'" + (result.ReturnData as ListSelectedRowCollection)[0].PrimaryKeyValue + "'";

                        }
                        if ((result.ReturnData as ListSelectedRowCollection).Count > 1)
                        {

                            for (int i = 0; i < (result.ReturnData as ListSelectedRowCollection).Count; i++)
                            {
                                djbh = djbh + "'" + (result.ReturnData as ListSelectedRowCollection)[i].PrimaryKeyValue + "'";

                                if (i + 1 < (result.ReturnData as ListSelectedRowCollection).Count)
                                {
                                    djbh = "" + djbh + "" + ",";
                                }


                            }

                        }



                        //        //   sb222.AppendLine(@"/*dialect*/  select  A.fbillno '生产订单号',B.FPLANSTARTDATE '计划开工日期',B.FPLANFINISHDATE '计划完工日期' from  T_PRD_MO A,T_PRD_MOENTRY B WHERE A.FID=B.FID and B.FPLANFINISHDATE >='" + KSRQ + "' and B.FPLANFINISHDATE<='" + JSRQ + "'    GROUP BY A.fbillno,B.FPLANSTARTDATE,B.FPLANFINISHDATE  ");
                        //                        sb222.AppendLine(@"/*dialect*/  select T_GL_VOUCHERENTRY.* from T_GL_VOUCHER
                        //left join T_GL_VOUCHERENTRY
                        //on T_GL_VOUCHER.FVOUCHERID=T_GL_VOUCHERENTRY.FVOUCHERID
                        //where fbillno in(" + djbh + ")     ");
                        sb222.AppendLine(@"/*dialect*/  				    
				    SELECT   DISTINCT  dbo.T_GL_VOUCHERENTRY.FENTRYID AS FID,  dbo.T_GL_VOUCHERENTRY.FDETAILID, 
                      dbo.T_GL_VOUCHERENTRY.FDEBIT -(case when  a.fcreate is null then 0 else  a.fcreate end )as FDEBIT,
					  dbo.T_GL_VOUCHERENTRY.FCREDIT-( case when a.fdebit is null then 0 else a.fdebit end ) as FCREDIT,
                    T_BD_FLEXITEMDETAILV.FFLEX4 as 'FFLEX4', T_BD_FLEXITEMDETAILV.FFLEX5 as 'FFLEX5', T_BD_FLEXITEMDETAILV.FFLEX6 as 'FFLEX6', T_BD_FLEXITEMDETAILV.FFLEX7 as 'FFLEX7', T_BD_FLEXITEMDETAILV.FFLEX8 as 'FFLEX8', T_BD_FLEXITEMDETAILV.FFLEX9 as 'FFLEX9', T_BD_FLEXITEMDETAILV.FFLEX10 as 'FFLEX10',T_BD_FLEXITEMDETAILV.FFLEX11 as 'FFLEX11', T_BD_FLEXITEMDETAILV.FF100002 as 'FF100002', T_BD_FLEXITEMDETAILV.FF100003 as 'FF100003',T_GL_VOUCHERENTRY.FAccountID,T_BAS_ASSISTANTDATAENTRY_L.FDATAVALUE as 'engeName',
T_BD_CUSTOMER_L.FNAME as 'souceName',t1_L.FNAME as 'suplliername',T_BD_CUSTOMER_L.FCUSTID as 'FCUSTID',T_BAS_ASSISTANTDATAENTRY.FNUMBER as 'fprojectnumber'
FROM         
                      dbo.T_GL_VOUCHERENTRY
                    left join
                      dbo.T_BD_FLEXITEMDETAILV ON dbo.T_GL_VOUCHERENTRY.FDETAILID = dbo.T_BD_FLEXITEMDETAILV.FID 
 left join T_BD_CUSTOMER_L on T_BD_CUSTOMER_L.FCUSTID=T_BD_FLEXITEMDETAILV.FFLEX6 and T_BD_CUSTOMER_L.FLOCALEID=2052
left join T_BAS_ASSISTANTDATAENTRY_L on T_BAS_ASSISTANTDATAENTRY_L.FENTRYID=T_BD_FLEXITEMDETAILV.FF100003 and T_BAS_ASSISTANTDATAENTRY_L.FLOCALEID=2052
left join   dbo.T_BD_SUPPLIER_L AS t1_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX4 = t1_L.FSUPPLIERID AND  t1_L.FLOCALEID = 2052
left join T_BAS_ASSISTANTDATAENTRY on T_BAS_ASSISTANTDATAENTRY.FENTRYID=T_BD_FLEXITEMDETAILV.FF100003
left join (select sum(FDEBIT)as 'fdebit',SUM(FCREDIT) as 'fcreate',F_PAEZ_Text2 from T_GL_VOUCHERENTRY where F_PAEZ_Text2<>''
group by F_PAEZ_Text2)a on a.F_PAEZ_Text2=T_GL_VOUCHERENTRY.FENTRYID
WHERE     (dbo.T_GL_VOUCHERENTRY.FACCOUNTID IN (100067,100057,100056,100066))
				and T_GL_VOUCHERENTRY.FENTRYID in(" + djbh + ")     ");


                        ds222 = AppServiceContext.DbUtils.ExecuteDataSet(Context, sb222.ToString());
                        int a = ds222.Tables[0].Rows.Count; //单据体总行数 

                        //this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                        //this.View.Model.SetValue("FACCOUNTID", "1003.01", 0);//科目编码
                        ////Field destStockField = View.BusinessInfo.GetField(destFiled);

                        //this.Model.SetValue("FDETAILID", "", 0);


                        //DynamicObject value = (DynamicObject)ObjectUtils.CreateCopy(
                        //View.Model.GetValue(srcValue, srcRow) as DynamicObject);

                        //RelatedFlexGroupField flexField = (RelatedFlexGroupField)destStockField;
                        ////获取单据体
                        //Entity entity = View.Model.BusinessInfo.GetEntity(EntityKey);
                        //DynamicObject dycol = View.Model.GetEntityDataObject(entity, destRow);
                        //DynamicObject cloneFlexObj = (DynamicObject)ObjectUtils.CreateCopy(value);
                        //flexField.DynamicProperty.SetValue(dycol, cloneFlexObj);
                        ////更新字段
                        //View.UpdateView(flexField.Key, destRow);


                        if (a > 0)
                        {
                            int lines = 0;
                            for (int i = 0; i < a; i++)
                            {
                                //FFLEX5 部门
                                //FF100002 资金来源
                                //FF10003 工程项目
                                //预收账款 预付账款 应付账款

                                #region 2303
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100067")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + "技术服务费", lines);//摘要

                                    }

                                    this.View.Model.SetValue("FACCOUNTID", 100067, lines);//科目编码
                                    //testc(ds222, i, lines, 0);
                                    this.View.Model.SetValue("FDEBIT", ds222.Tables[0].Rows[i]["FCREDIT"].ToString(), lines);//借方金额
                                    this.View.Model.SetValue("F_PAEZ_Text2", ds222.Tables[0].Rows[i]["FID"].ToString(), lines);
                                    this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    //this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//贷方金额
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100067")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + "技术服务费", lines);//摘要

                                    }

                                    this.View.Model.SetValue("FACCOUNTID", 100663, lines);//科目编码
                                    this.View.Model.SetValue("FCREDIT", (float.Parse(ds222.Tables[0].Rows[i]["FCREDIT"].ToString()) - float.Parse(ds222.Tables[0].Rows[i]["FCREDIT"].ToString()) / 1.06 * 0.06), lines);//贷方金额
 


                                    StringBuilder sb225 = new StringBuilder();
                                    sb225.AppendLine(@"/*dialect*/  				    
				   
select  T_BD_FLEXITEMDETAILV.FFLEX4 as 'FFLEX4', T_BD_FLEXITEMDETAILV.FFLEX5 as 'FFLEX5', T_BD_FLEXITEMDETAILV.FFLEX6 as 'FFLEX6', T_BD_FLEXITEMDETAILV.FFLEX7 as 'FFLEX7', T_BD_FLEXITEMDETAILV.FFLEX8 as 'FFLEX8', T_BD_FLEXITEMDETAILV.FFLEX9 as 'FFLEX9', T_BD_FLEXITEMDETAILV.FFLEX10 as 'FFLEX10',T_BD_FLEXITEMDETAILV.FFLEX11 as 'FFLEX11', T_BD_FLEXITEMDETAILV.FF100002 as 'FF100002',T_BD_FLEXITEMDETAILV.FF100003 as 'FF100003',a.FDETAILID from T_GL_VOUCHERENTRY left join T_GL_VOUCHER on T_GL_VOUCHERENTRY.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID
left join T_GL_VOUCHERENTRY a on a.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID and a.FACCOUNTID=100517
left join  dbo.T_BD_FLEXITEMDETAILV ON a.FDETAILID = dbo.T_BD_FLEXITEMDETAILV.FID 
				where  T_GL_VOUCHERENTRY.FENTRYID in(" + djbh + ")     ");

                                    DataSet ds225 = new DataSet();
                                    ds225 = AppServiceContext.DbUtils.ExecuteDataSet(Context, sb225.ToString());
                                    
                                    
                                    //testu(ds225, 0, lines, 0);
                                    this.View.Model.SetValue("FDETAILID", ds225.Tables[0].Rows[i]["FDETAILID"], lines);
                                    //this.View.Model.SetValue("FDETAILID", 102455, lines);
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100067")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + "技术服务费", lines);//摘要

                                    }

                                    this.View.Model.SetValue("FACCOUNTID", 100749, lines);//科目编码
                                    this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FCREDIT"].ToString()) / 1.06 * 0.06, lines);//借方金额

                                    lines++;
                                }
                                #endregion 2303
                                #region 1213

                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100057")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + "技术服务费", lines);//摘要

                                    }
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码
                                        //testc(ds222, i, lines, 0);
                                        this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100638, lines);//科目编码
                                        StringBuilder sb223 = new StringBuilder();
                                        sb223.AppendLine(@"/*dialect*/  				    
				   
select  T_BD_FLEXITEMDETAILV.FFLEX4 as 'FFLEX4', T_BD_FLEXITEMDETAILV.FFLEX5 as 'FFLEX5', T_BD_FLEXITEMDETAILV.FFLEX6 as 'FFLEX6', T_BD_FLEXITEMDETAILV.FFLEX7 as 'FFLEX7', T_BD_FLEXITEMDETAILV.FFLEX8 as 'FFLEX8', T_BD_FLEXITEMDETAILV.FFLEX9 as 'FFLEX9', T_BD_FLEXITEMDETAILV.FFLEX10 as 'FFLEX10',T_BD_FLEXITEMDETAILV.FFLEX11 as 'FFLEX11', T_BD_FLEXITEMDETAILV.FF100002 as 'FF100002',T_BD_FLEXITEMDETAILV.FF100003 as 'FF100003',a.FDETAILID from T_GL_VOUCHERENTRY left join T_GL_VOUCHER on T_GL_VOUCHERENTRY.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID
left join T_GL_VOUCHERENTRY a on a.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID and a.FACCOUNTID=100805
left join  dbo.T_BD_FLEXITEMDETAILV ON a.FDETAILID = dbo.T_BD_FLEXITEMDETAILV.FID 
				where T_GL_VOUCHERENTRY.FENTRYID in(" + djbh + ")     ");
                                        DataSet ds223 = new DataSet();
                                        ds223 = AppServiceContext.DbUtils.ExecuteDataSet(Context, sb223.ToString());
                                        //testc(ds223, 0, lines, 0);
                                        this.View.Model.SetValue("FDETAILID", ds223.Tables[0].Rows[i]["FDETAILID"], lines);
                                    }
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    this.View.Model.SetValue("FDEBIT", (float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) - float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06), lines);//借方金额
                                    
                                    //this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06, lines);//借方金额
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100057")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + "技术服务费", lines);//摘要

                                    }

                                    this.View.Model.SetValue("FACCOUNTID", 100428, lines);//科目编码

                                    //this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额
                                    this.View.Model.SetValue("FDEBIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06, lines);//借方金额

                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100057")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲预付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + "技术服务费", lines);//摘要

                                    }

                                    this.View.Model.SetValue("FACCOUNTID", 100057, lines);//科目编码
                                    testc(ds222, i, lines, 0);
                                    this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额
                                    this.View.Model.SetValue("F_PAEZ_Text2", ds222.Tables[0].Rows[i]["FID"].ToString(), lines);//借方金额
                                    this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    //this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06, lines);//借方金额
                                    lines++;
                                }
                                #endregion 1213
                                #region 2302
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100066")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + "技术服务费", lines);//摘要

                                    }


                                    this.View.Model.SetValue("FACCOUNTID", 100066, lines);//科目编码
                                    testc(ds222, i, lines, 0);
                                    this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    this.View.Model.SetValue("FDEBIT", ds222.Tables[0].Rows[i]["FCREDIT"].ToString(), lines);//借方金额
                                    //this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06, lines);//借方金额
                                    this.View.Model.SetValue("F_PAEZ_Text2", ds222.Tables[0].Rows[i]["FID"].ToString(), lines);//借方金额
                                    this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100066")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + "技术服务费", lines);//摘要

                                    }

                                    this.View.Model.SetValue("FACCOUNTID", 100506, lines);//科目编码

                                    //this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额
                                    this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FCREDIT"].ToString(), lines);//贷方金额
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100066")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + "技术服务费", lines);//摘要

                                    }
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门

                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目

                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100805, lines);//科目编码


                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目
                                        this.View.Model.SetValue("$$FDetailID__FFLEX9", "100264", lines);//6费用项目 100264为技术服务费内码，select * from T_BD_FLEXITEMDETAILV where FFLEX9 = '100264'
                                    }
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    this.View.Model.SetValue("FDEBIT", ds222.Tables[0].Rows[i]["FCREDIT"].ToString(), lines);//借方金额
                                    //this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    StringBuilder sb225 = new StringBuilder();
                                    sb225.AppendLine(@"/*dialect*/  				    
				   
select  T_BD_FLEXITEMDETAILV.FFLEX4 as 'FFLEX4', T_BD_FLEXITEMDETAILV.FFLEX5 as 'FFLEX5', T_BD_FLEXITEMDETAILV.FFLEX6 as 'FFLEX6', T_BD_FLEXITEMDETAILV.FFLEX7 as 'FFLEX7', T_BD_FLEXITEMDETAILV.FFLEX8 as 'FFLEX8', T_BD_FLEXITEMDETAILV.FFLEX9 as 'FFLEX9', T_BD_FLEXITEMDETAILV.FFLEX10 as 'FFLEX10',T_BD_FLEXITEMDETAILV.FFLEX11 as 'FFLEX11', T_BD_FLEXITEMDETAILV.FF100002 as 'FF100002',T_BD_FLEXITEMDETAILV.FF100003 as 'FF100003',dbo.T_GL_VOUCHERENTRY.FDETAILID from T_GL_VOUCHERENTRY left join T_GL_VOUCHER on T_GL_VOUCHERENTRY.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID
left join T_GL_VOUCHERENTRY a on a.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID and a.FACCOUNTID=100517
left join  dbo.T_BD_FLEXITEMDETAILV ON a.FDETAILID = dbo.T_BD_FLEXITEMDETAILV.FID 
				where  T_GL_VOUCHERENTRY.FENTRYID in(" + djbh + ")     ");

                                    DataSet ds225 = new DataSet();
                                    ds225 = AppServiceContext.DbUtils.ExecuteDataSet(Context, sb225.ToString());


                                    testu(ds225, 0, lines, 0);
                                    //this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06, lines);//借方金额
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100066")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应付" + ds222.Tables[0].Rows[i]["suplliername"].ToString() + "技术服务费", lines);//摘要

                                    }
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门

                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目

                                        this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FCREDIT"].ToString(), lines);//借方金额
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100517, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目


                                        this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FCREDIT"].ToString(), lines);//借方金额
                                        StringBuilder sb225 = new StringBuilder();
                                        sb225.AppendLine(@"/*dialect*/  				    
				   
select  T_BD_FLEXITEMDETAILV.FFLEX4 as 'FFLEX4', T_BD_FLEXITEMDETAILV.FFLEX5 as 'FFLEX5', T_BD_FLEXITEMDETAILV.FFLEX6 as 'FFLEX6', T_BD_FLEXITEMDETAILV.FFLEX7 as 'FFLEX7', T_BD_FLEXITEMDETAILV.FFLEX8 as 'FFLEX8', T_BD_FLEXITEMDETAILV.FFLEX9 as 'FFLEX9', T_BD_FLEXITEMDETAILV.FFLEX10 as 'FFLEX10',T_BD_FLEXITEMDETAILV.FFLEX11 as 'FFLEX11', T_BD_FLEXITEMDETAILV.FF100002 as 'FF100002',T_BD_FLEXITEMDETAILV.FF100003 as 'FF100003',dbo.T_GL_VOUCHERENTRY.FDETAILID from T_GL_VOUCHERENTRY left join T_GL_VOUCHER on T_GL_VOUCHERENTRY.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID
left join T_GL_VOUCHERENTRY a on a.FVOUCHERID=T_GL_VOUCHER.FVOUCHERID and a.FACCOUNTID=100517
left join  dbo.T_BD_FLEXITEMDETAILV ON a.FDETAILID = dbo.T_BD_FLEXITEMDETAILV.FID 
				where  T_GL_VOUCHERENTRY.FENTRYID in(" + djbh + ")     ");

                                        DataSet ds225 = new DataSet();
                                        ds225 = AppServiceContext.DbUtils.ExecuteDataSet(Context, sb225.ToString());


                                        testu(ds225, 0, lines, 0);
                                        //this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                        //this.View.InvokeFieldUpdateService("FDetailID", lines);                                                                         //this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06, lines);//借方金额
                                        lines++;
                                    }



                                    //  this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i][1].ToString(), i);//核算维度
                                    //this.View.Model.SetValue("FDEBIT", ds222.Tables[0].Rows[i][2].ToString(), i);//余额
                                    ////this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i][27].ToString() + ";" + ds222.Tables[0].Rows[i][28].ToString() + ";" + ds222.Tables[0].Rows[i][29].ToString() + ";" + ds222.Tables[0].Rows[i][30].ToString() + ";" + ds222.Tables[0].Rows[i][31].ToString() + ";" + ds222.Tables[0].Rows[i][32].ToString() + ";" + ds222.Tables[0].Rows[i][33].ToString() + ";" + ds222.Tables[0].Rows[i][34].ToString() + ";" + ds222.Tables[0].Rows[i][35].ToString(), i);//核算维度


                                    //this.View.Model.SetValue("FDETAILID_FFLEX5", ds222.Tables[0].Rows[i][27].ToString(), i);//部门
                                    //this.View.Model.SetValue("FDETAILID_FF100002", ds222.Tables[0].Rows[i][28].ToString(), i);//资金来源
                                    //this.View.Model.SetValue("FDETAILID_FF100003", ds222.Tables[0].Rows[i][29].ToString(), i);//工程项目
                                }
                                #endregion 2302
                                #region 1212
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + "技术服务费", lines);//摘要

                                    }

                                    this.View.Model.SetValue("FACCOUNTID", 100506, lines);//科目编码

                                    //this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额
                                    this.View.Model.SetValue("FDEBIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//贷方金额
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + "技术服务费", lines);//摘要

                                    }


                                    this.View.Model.SetValue("FACCOUNTID", 100056, lines);//科目编码
                                    testc(ds222, i, lines, 0);
                                    this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额
                                    //this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.06, lines);//借方金额
                                    this.View.Model.SetValue("F_PAEZ_Text2", ds222.Tables[0].Rows[i]["FID"].ToString(), lines);//借方金额
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + "技术服务费", lines);//摘要

                                    }
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目
                                        this.View.Model.SetValue("$$FDetailID__FFLEX9", "100024", lines);//6费用项目
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100517, lines);//科目编码


                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目
                                        this.View.Model.SetValue("$$FDetailID__FFLEX9", "100264", lines);//6费用项目 100264为技术服务费内码，select * from T_BD_FLEXITEMDETAILV where FFLEX9 = '100264'
                                    }
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    this.View.Model.SetValue("FDEBIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额
                                    //this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);

                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FEXPLANATION", "冲应收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + "技术服务费", lines);//摘要

                                    }
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目
                                        this.View.Model.SetValue("$$FDetailID__FFLEX9", "100258", lines);//6费用项目
                                        this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100805, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目

                                        this.View.Model.SetValue("FCREDIT", ds222.Tables[0].Rows[i]["FDEBIT"].ToString(), lines);//借方金额


                                    }
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    //this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    lines++;
                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                    //if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                    //{
                                    //    this.View.Model.SetValue("FEXPLANATION", "支出" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                    //}
                                    //else
                                    //{
                                    DynamicObject bianma = this.View.Model.GetValue("FDETAILID", 0) as DynamicObject;
                                    this.View.Model.SetValue("FEXPLANATION", "支出" + ds222.Tables[0].Rows[i]["fprojectnumber"].ToString() + "项目管理费", lines);//摘要

                                    //}
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门

                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目
                                        this.View.Model.SetValue("FDEBIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100805, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目
                                        this.View.Model.SetValue("$$FDetailID__FFLEX9", "100258", lines);//6费用项目

                                        this.View.Model.SetValue("FDEBIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额

                                    }
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    //this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    lines++;

                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                                                                 //if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                                                                 //{
                                                                                 //    this.View.Model.SetValue("FEXPLANATION", "支出" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                                                                 //}
                                                                                 //else
                                                                                 //{
                                    this.View.Model.SetValue("FEXPLANATION", "支出" + ds222.Tables[0].Rows[i]["fprojectnumber"].ToString() + "项目管理费", lines);//摘要

                                    //}
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门

                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目
                                        this.View.Model.SetValue("FDEBIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100517, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", ds222.Tables[0].Rows[i]["FFLEX5"].ToString(), lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", ds222.Tables[0].Rows[i]["FF100003"].ToString(), lines); //100003工程项目


                                        this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额

                                    }
                                    //this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    lines++;

                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                                                                 //if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                                                                 //{
                                                                                 //    this.View.Model.SetValue("FEXPLANATION", "收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                                                                 //}
                                                                                 //else
                                                                                 //{
                                    this.View.Model.SetValue("FEXPLANATION", "收" + ds222.Tables[0].Rows[i]["fprojectnumber"].ToString() + "项目管理费", lines);//摘要

                                    //}
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", "100313", lines);//2部门

                                        this.View.Model.SetValue("$$FDetailID__FF100003", "58464c308eb927", lines); //100003工程项目
                                        this.View.Model.SetValue("FDEBIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100517, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", "100313", lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", "57369269a6fee1", lines); //100003工程项目


                                        this.View.Model.SetValue("FDEBIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额

                                    }
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    //this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    lines++;

                                }
                                if (ds222.Tables[0].Rows[i]["FAccountID"].ToString() == "100056")
                                {
                                    this.View.Model.CreateNewEntryRow("FEntity");//添加一行表体
                                                                                 //if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费" || ds222.Tables[0].Rows[i]["engeName"].ToString() == "检测费")
                                                                                 //{
                                                                                 //    this.View.Model.SetValue("FEXPLANATION", "收" + ds222.Tables[0].Rows[i]["souceName"].ToString() + ds222.Tables[0].Rows[i]["engeName"].ToString(), lines);//摘要
                                                                                 //}
                                                                                 //else
                                                                                 //{
                                    this.View.Model.SetValue("FEXPLANATION", "收" + ds222.Tables[0].Rows[i]["fprojectnumber"].ToString() + "项目管理费", lines);//摘要

                                    //}
                                    if (ds222.Tables[0].Rows[i]["engeName"].ToString() == "房屋租赁费")
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100652, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", "100313", lines);//2部门

                                        this.View.Model.SetValue("$$FDetailID__FF100003", "58464c308eb927", lines); //100003工程项目
                                        this.View.Model.SetValue("FDEBIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额
                                    }
                                    else
                                    {
                                        this.View.Model.SetValue("FACCOUNTID", 100805, lines);//科目编码

                                        this.View.Model.SetValue("$$FDetailID__FFLEX5", "100313", lines);//2部门
                                        this.View.Model.SetValue("$$FDetailID__FF100002", "573415a09004f8", lines);//100002资金来源
                                        this.View.Model.SetValue("$$FDetailID__FF100003", "57369269a6fee1", lines); //100003工程项目


                                        this.View.Model.SetValue("FCREDIT", float.Parse(ds222.Tables[0].Rows[i]["FDEBIT"].ToString()) / 1.06 * 0.08, lines);//借方金额

                                    }
                                   // this.View.Model.SetValue("FDETAILID", ds222.Tables[0].Rows[i]["FDETAILID"], lines);
                                    //this.View.InvokeFieldUpdateService("FDetailID", lines);
                                    lines++;

                                }
                                #endregion 1212

                            }
                        }
                    }
                }));

            }
        }
    }
}
//视图sql
//SELECT dbo.T_GL_VOUCHERENTRY.FEXPLANATION, dbo.T_GL_VOUCHERENTRY.FENTRYID AS FID,
//                   dbo.T_GL_VOUCHER.FBILLNO, dbo.T_GL_VOUCHER.FDATE AS FCREATEDATE, dbo.T_GL_VOUCHERENTRY.FDETAILID,
//                   dbo.T_GL_VOUCHERENTRY.FDEBIT - (CASE WHEN a.fcreate IS NULL THEN 0 ELSE a.fcreate END) AS FDEBIT,
//                   dbo.T_GL_VOUCHERENTRY.FCREDIT - (CASE WHEN a.fdebit1 IS NULL THEN 0 ELSE a.fdebit1 END) AS FCREDIT,
//                   dbo.T_BD_ACCOUNT.FNUMBER, dbo.T_BD_ACCOUNT_L.FNAME, (CASE WHEN t1_L.FNAME IS NULL
//                   THEN '' ELSE t1_L.FNAME + ',' END) + (CASE WHEN t2_L.FNAME IS NULL THEN '' ELSE t2_L.FNAME + ',' END) 
//                   +(CASE WHEN t3_L.FNAME IS NULL THEN '' ELSE t3_L.FNAME + ',' END) +(CASE WHEN t4_L.FNAME IS NULL

//                 THEN '' ELSE t4_L.FNAME + ',' END) +(CASE WHEN t5_L.FNAME IS NULL THEN '' ELSE t5_L.FNAME + ',' END)
//                   +(CASE WHEN t6_L.FNAME IS NULL THEN '' ELSE t6_L.FNAME + ',' END) +(CASE WHEN t7_L.FNAME IS NULL

//                 THEN '' ELSE t7_L.FNAME + ',' END) +(CASE WHEN t8_L.FNAME IS NULL THEN '' ELSE t8_L.FNAME + ',' END)
//                   +(CASE WHEN t9_L.FDATAVALUE IS NULL THEN '' ELSE t9_L.FDATAVALUE + ',' END)
//                   +(CASE WHEN t10_L.FDATAVALUE IS NULL THEN '' ELSE t10_L.FDATAVALUE END) AS Expr1, 16394 AS FMODIFIERID,
//                   1 AS FUSEORGID, 16394 AS FCREATORID, 1 AS FCREATEORGID, '2021-03-22 19:33:53.000' AS FMODIFYDATE,
//                   1 AS FORGID
//FROM      dbo.T_GL_VOUCHER LEFT OUTER JOIN
//                   dbo.T_GL_VOUCHERENTRY ON 
//                   dbo.T_GL_VOUCHER.FVOUCHERID = dbo.T_GL_VOUCHERENTRY.FVOUCHERID LEFT OUTER JOIN
//                   dbo.T_BD_ACCOUNT ON dbo.T_GL_VOUCHERENTRY.FACCOUNTID = dbo.T_BD_ACCOUNT.FACCTID LEFT OUTER JOIN
//                   dbo.T_BD_ACCOUNT_L ON dbo.T_BD_ACCOUNT_L.FACCTID = dbo.T_BD_ACCOUNT.FACCTID AND 
//                   dbo.T_BD_ACCOUNT_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_BD_FLEXITEMDETAILV ON 
//                   dbo.T_GL_VOUCHERENTRY.FDETAILID = dbo.T_BD_FLEXITEMDETAILV.FID LEFT OUTER JOIN
//                   dbo.T_BD_SUPPLIER_L AS t1_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX4 = t1_L.FSUPPLIERID AND 
//                   t1_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_BD_DEPARTMENT_L AS t2_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX5 = t2_L.FDEPTID AND 
//                   t2_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_BD_CUSTOMER_L AS t3_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX6 = t3_L.FCUSTID AND 
//                   t3_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_HR_EMPINFO_L AS t4_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX7 = t4_L.FID AND 
//                   t4_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_BD_MATERIAL_L AS t5_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX8 = t5_L.FMATERIALID AND 
//                   t5_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_BD_EXPENSE_L AS t6_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX9 = t6_L.FEXPID AND 
//                   t6_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_FA_ASSETTYPE_L AS t7_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX10 = t7_L.FID AND 
//                   t7_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_ORG_ORGANIZATIONS_L AS t8_L ON dbo.T_BD_FLEXITEMDETAILV.FFLEX11 = t8_L.FORGID AND 
//                   t8_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_BAS_ASSISTANTDATAENTRY_L AS t9_L ON dbo.T_BD_FLEXITEMDETAILV.FF100002 = t9_L.FENTRYID AND 
//                   t9_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                   dbo.T_BAS_ASSISTANTDATAENTRY_L AS t10_L ON dbo.T_BD_FLEXITEMDETAILV.FF100003 = t10_L.FENTRYID AND 
//                   t10_L.FLOCALEID = 2052 LEFT OUTER JOIN
//                       (SELECT  SUM(FDEBIT) AS 'fdebit1', SUM(FCREDIT) AS 'fcreate', F_ORA_TEXT2
//                        FROM       dbo.T_GL_VOUCHERENTRY AS T_GL_VOUCHERENTRY_1
//                        WHERE    (F_ORA_TEXT2 <> '')
//                        GROUP BY F_ORA_TEXT2) AS a ON a.F_ORA_TEXT2 = dbo.T_GL_VOUCHERENTRY.FENTRYID
//WHERE   (dbo.T_GL_VOUCHERENTRY.FACCOUNTID IN (100067, 100057, 100056, 100066)) AND
//                   (dbo.T_GL_VOUCHER.F_PAEZ_TEXT = '') AND(dbo.T_GL_VOUCHER.FBILLNO > 0) AND
//                  (0 < (CASE T_GL_VOUCHERENTRY.FACCOUNTID WHEN 100067 THEN FCREDIT WHEN 100057 THEN FDEBIT WHEN 100056 THEN

//                   FDEBIT WHEN 100066 THEN FCREDIT ELSE 0 END))




//原sql
//SELECT DISTINCT

//                dbo.T_GL_BALANCE_100200.FAccountID,T_BD_FLEXITEMDETAILV.FID as 'FDetialid' ,
//                   dbo.T_GL_BALANCE_100200.FBeginBalanceFor + dbo.T_GL_BALANCE_100200.FDebitFor - dbo.T_GL_BALANCE_100200.FCreditFor
//                    AS FBlance, dbo.T_BD_FLEXITEMDETAILV.FFLEX6,  1 AS FUSEORGID,
//                   16394 AS FCREATORID, 1 AS FCREATEORGID, T_BD_FLEXITEMDETAILV.FID AS FBILLNO, 1 AS FORGID,
//                   '2021-03-22 19:18:26.000' AS FCREATEDATE, 16394 AS FMODIFIERID, '2021-03-22 19:33:53.000' AS FMODIFYDATE, ROW_NUMBER () over(order by dbo.T_GL_BALANCE_100200.FAccountID)as fid,T_BD_FLEXITEMDETAILV.FFLEX4 as 'FFLEX4', T_BD_FLEXITEMDETAILV.FFLEX5 as 'FFLEX5', T_BD_FLEXITEMDETAILV.FFLEX6 as 'FFLEX6', T_BD_FLEXITEMDETAILV.FFLEX7 as 'FFLEX7', T_BD_FLEXITEMDETAILV.FFLEX8 as 'FFLEX8', T_BD_FLEXITEMDETAILV.FFLEX9 as 'FFLEX9', T_BD_FLEXITEMDETAILV.FFLEX10 as 'FFLEX10',T_BD_FLEXITEMDETAILV.FFLEX11 as 'FFLEX11', T_BD_FLEXITEMDETAILV.FF100002 as 'FF100002', T_BD_FLEXITEMDETAILV.FF100003 as 'FF100003'
//FROM dbo.T_GL_BALANCE_100200


//                    LEFT OUTER JOIN dbo.T_BD_FLEXITEMDETAILV ON dbo.T_GL_BALANCE_100200.FDetailID = dbo.T_BD_FLEXITEMDETAILV.FID

//                    LEFT OUTER JOIN t_BD_Supplier_L t1_L ON (T_BD_FLEXITEMDETAILV.FFLEX4 = t1_L.FSupplierId AND t1_L.FLOCALEID = 2052)

//                    LEFT OUTER JOIN T_BD_DEPARTMENT_L t2_L ON(T_BD_FLEXITEMDETAILV.FFLEX5 = t2_L.FDEPTID AND t2_L.FLOCALEID = 2052)

//                    LEFT OUTER JOIN T_BD_CUSTOMER_L t3_L ON(T_BD_FLEXITEMDETAILV.FFLEX6 = t3_L.FCUSTID AND t3_L.FLOCALEID = 2052)

//                     LEFT OUTER JOIN T_HR_EMPINFO_L t4_L ON(T_BD_FLEXITEMDETAILV.FFLEX7 = t4_L.FID AND t4_L.FLOCALEID = 2052)

//                     LEFT OUTER JOIN T_BD_MATERIAL_L t5_L ON(T_BD_FLEXITEMDETAILV.FFLEX8 = t5_L.FMATERIALID AND t5_L.FLOCALEID = 2052)

//                     LEFT OUTER JOIN T_BD_EXPENSE_L t6_L ON(T_BD_FLEXITEMDETAILV.FFLEX9 = t6_L.FEXPID AND t6_L.FLOCALEID = 2052)

//                     LEFT OUTER JOIN T_FA_ASSETTYPE_L t7_L ON(T_BD_FLEXITEMDETAILV.FFLEX10 = t7_L.FID AND t7_L.FLOCALEID = 2052)

//                     LEFT OUTER JOIN T_ORG_Organizations_L t8_L ON(T_BD_FLEXITEMDETAILV.FFLEX11 = t8_L.FOrgID AND t8_L.FLOCALEID = 2052)

//                     LEFT OUTER JOIN T_BAS_ASSISTANTDATAENTRY_L t9_L ON(T_BD_FLEXITEMDETAILV.FF100002 = t9_L.FEntryID AND t9_L.FLOCALEID = 2052)

//                     LEFT OUTER JOIN T_BAS_ASSISTANTDATAENTRY_L t10_L ON(T_BD_FLEXITEMDETAILV.FF100003 = t10_L.FEntryID AND t10_L.FLOCALEID = 2052)

//WHERE(dbo.T_BD_FLEXITEMDETAILV.FID > 0) AND
//                (dbo.T_GL_BALANCE_100200.FBeginBalanceFor + dbo.T_GL_BALANCE_100200.FDebitFor - dbo.T_GL_BALANCE_100200.FCreditFor
//                    > 0)

//                and T_BD_FLEXITEMDETAILV.FID in (" + djbh + ")     ")


//从凭证某列取核算维度
//select T_BD_FLEXITEMDETAILV.FFLEX4 as 'FFLEX4', T_BD_FLEXITEMDETAILV.FFLEX5 as 'FFLEX5', T_BD_FLEXITEMDETAILV.FFLEX6 as 'FFLEX6', T_BD_FLEXITEMDETAILV.FFLEX7 as 'FFLEX7', T_BD_FLEXITEMDETAILV.FFLEX8 as 'FFLEX8', T_BD_FLEXITEMDETAILV.FFLEX9 as 'FFLEX9', T_BD_FLEXITEMDETAILV.FFLEX10 as 'FFLEX10', T_BD_FLEXITEMDETAILV.FFLEX11 as 'FFLEX11', T_BD_FLEXITEMDETAILV.FF100002 as 'FF100002', T_BD_FLEXITEMDETAILV.FF100003 as 'FF100003', dbo.T_GL_VOUCHERENTRY.FDETAILID from T_GL_VOUCHERENTRY left join T_GL_VOUCHER on T_GL_VOUCHERENTRY.FVOUCHERID= T_GL_VOUCHER.FVOUCHERID
//left join T_GL_VOUCHERENTRY a on a.FVOUCHERID= T_GL_VOUCHER.FVOUCHERID and a.FACCOUNTID= 100805
//left join  dbo.T_BD_FLEXITEMDETAILV ON a.FDETAILID = dbo.T_BD_FLEXITEMDETAILV.FID

//                where FFLEX9 != 0 and T_GL_VOUCHERENTRY.FENTRYID in (" + djbh + ")

