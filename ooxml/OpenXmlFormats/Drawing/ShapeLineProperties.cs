// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Xml;
    using NPOI.OpenXml4Net.Util;
    using System.IO;


    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_LineEndProperties
    {

        private ST_LineEndType typeField= ST_LineEndType.none;

        private ST_LineEndWidth wField= ST_LineEndWidth.sm;

        private ST_LineEndLength lenField= ST_LineEndLength.sm;

        public static CT_LineEndProperties Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_LineEndProperties ctObj = new CT_LineEndProperties();
            if (node.Attributes["type"] != null)
                ctObj.type = (ST_LineEndType)Enum.Parse(typeof(ST_LineEndType), node.Attributes["type"].Value);
            if (node.Attributes["w"] != null)
                ctObj.w = (ST_LineEndWidth)Enum.Parse(typeof(ST_LineEndWidth), node.Attributes["w"].Value);
            if (node.Attributes["len"] != null)
                ctObj.len = (ST_LineEndLength)Enum.Parse(typeof(ST_LineEndLength), node.Attributes["len"].Value);
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            if(this.type!= ST_LineEndType.none)
                XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
            if (this.w != ST_LineEndWidth.sm)
                XmlHelper.WriteAttribute(sw, "w", this.w.ToString());
            if (this.len != ST_LineEndLength.sm)
                XmlHelper.WriteAttribute(sw, "len", this.len.ToString());
            sw.Write(">");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        [XmlAttribute]
        public ST_LineEndType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }


        [XmlAttribute]
        public ST_LineEndWidth w
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        [XmlAttribute]
        public ST_LineEndLength len
        {
            get
            {
                return this.lenField;
            }
            set
            {
                this.lenField = value;
            }
        }

    }

    
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_LineEndType
    {

        /// <remarks/>
        none,

        /// <remarks/>
        triangle,

        /// <remarks/>
        stealth,

        /// <remarks/>
        diamond,

        /// <remarks/>
        oval,

        /// <remarks/>
        arrow,
    }

    
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_LineEndWidth
    {

        /// <remarks/>
        sm,

        /// <remarks/>
        med,

        /// <remarks/>
        lg,
    }

    
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_LineEndLength
    {

        /// <remarks/>
        sm,

        /// <remarks/>
        med,

        /// <remarks/>
        lg,
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_LineJoinBevel
    {
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_LineJoinRound
    {
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_LineJoinMiterProperties
    {
        public static CT_LineJoinMiterProperties Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_LineJoinMiterProperties ctObj = new CT_LineJoinMiterProperties();
            ctObj.lim = XmlHelper.ReadInt(node.Attributes["lim"]);
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "lim", this.lim);
            sw.Write(">");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        private int limField;

        private bool limFieldSpecified;

        [XmlAttribute]
        public int lim
        {
            get
            {
                return this.limField;
            }
            set
            {
                this.limField = value;
            }
        }

        [XmlIgnore]
        public bool limSpecified
        {
            get
            {
                return this.limFieldSpecified;
            }
            set
            {
                this.limFieldSpecified = value;
            }
        }
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_PresetLineDashProperties
    {
        public static CT_PresetLineDashProperties Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PresetLineDashProperties ctObj = new CT_PresetLineDashProperties();
            if (node.Attributes["val"] != null)
                ctObj.val = (ST_PresetLineDashVal)Enum.Parse(typeof(ST_PresetLineDashVal), node.Attributes["val"].Value);
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
            sw.Write(">");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        private ST_PresetLineDashVal valField;

        private bool valFieldSpecified;

        [XmlAttribute]
        public ST_PresetLineDashVal val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }

        [XmlIgnore]
        public bool valSpecified
        {
            get
            {
                return this.valFieldSpecified;
            }
            set
            {
                this.valFieldSpecified = value;
            }
        }
    }

    
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_PresetLineDashVal
    {

        /// <remarks/>
        solid,

        /// <remarks/>
        dot,

        /// <remarks/>
        dash,

        /// <remarks/>
        lgDash,

        /// <remarks/>
        dashDot,

        /// <remarks/>
        lgDashDot,

        /// <remarks/>
        lgDashDotDot,

        /// <remarks/>
        sysDash,

        /// <remarks/>
        sysDot,

        /// <remarks/>
        sysDashDot,

        /// <remarks/>
        sysDashDotDot,
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_DashStop
    {
        public static CT_DashStop Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DashStop ctObj = new CT_DashStop();
            ctObj.d = XmlHelper.ReadInt(node.Attributes["d"]);
            ctObj.sp = XmlHelper.ReadInt(node.Attributes["sp"]);
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "d", this.d);
            XmlHelper.WriteAttribute(sw, "sp", this.sp);
            sw.Write(">");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        private int dField;

        private int spField;

        [XmlAttribute]
        public int d
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        [XmlAttribute]
        public int sp
        {
            get
            {
                return this.spField;
            }
            set
            {
                this.spField = value;
            }
        }
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_DashStopList
    {

        private List<CT_DashStop> dsField;

        public CT_DashStopList()
        {
            //this.dsField = new List<CT_DashStop>();
        }

        [XmlElement("ds", Order = 0)]
        public List<CT_DashStop> ds
        {
            get
            {
                return this.dsField;
            }
            set
            {
                this.dsField = value;
            }
        }
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_LineProperties
    {

        private CT_NoFillProperties noFillField;

        private CT_SolidColorFillProperties solidFillField;

        private CT_GradientFillProperties gradFillField;

        private CT_PatternFillProperties pattFillField;

        private CT_PresetLineDashProperties prstDashField;

        private List<CT_DashStop> custDashField;

        private CT_LineJoinRound roundField;

        private CT_LineJoinBevel bevelField;

        private CT_LineJoinMiterProperties miterField;

        private CT_LineEndProperties headEndField;

        private CT_LineEndProperties tailEndField;

        private CT_OfficeArtExtensionList extLstField;

        private int wField = 0;

        private bool wFieldSpecified;

        private ST_LineCap capField = ST_LineCap.NONE;

        private bool capFieldSpecified;

        private ST_CompoundLine cmpdField = ST_CompoundLine.NONE;

        private bool cmpdFieldSpecified;

        private ST_PenAlignment algnField = ST_PenAlignment.NONE;

        private bool algnFieldSpecified;
        public static CT_LineProperties Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_LineProperties ctObj = new CT_LineProperties();
            ctObj.w = XmlHelper.ReadInt(node.Attributes["w"]);
            if (node.Attributes["cap"] != null)
                ctObj.cap = (ST_LineCap)Enum.Parse(typeof(ST_LineCap), node.Attributes["cap"].Value);
            if (node.Attributes["cmpd"] != null)
                ctObj.cmpd = (ST_CompoundLine)Enum.Parse(typeof(ST_CompoundLine), node.Attributes["cmpd"].Value);
            if (node.Attributes["algn"] != null)
                ctObj.algn = (ST_PenAlignment)Enum.Parse(typeof(ST_PenAlignment), node.Attributes["algn"].Value);
            ctObj.custDash = new List<CT_DashStop>();
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.LocalName == "noFill")
                    ctObj.noFill = new CT_NoFillProperties();
                else if (childNode.LocalName == "solidFill")
                    ctObj.solidFill = CT_SolidColorFillProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "gradFill")
                    ctObj.gradFill = CT_GradientFillProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "pattFill")
                    ctObj.pattFill = CT_PatternFillProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "prstDash")
                    ctObj.prstDash = CT_PresetLineDashProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "round")
                    ctObj.round = new CT_LineJoinRound();
                else if (childNode.LocalName == "bevel")
                    ctObj.bevel = new CT_LineJoinBevel();
                else if (childNode.LocalName == "miter")
                    ctObj.miter = CT_LineJoinMiterProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "headEnd")
                    ctObj.headEnd = CT_LineEndProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "tailEnd")
                    ctObj.tailEnd = CT_LineEndProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "extLst")
                    ctObj.extLst = CT_OfficeArtExtensionList.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "custDash")
                    ctObj.custDash.Add(CT_DashStop.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "w", this.w);
            if(this.cap!= ST_LineCap.NONE)
                XmlHelper.WriteAttribute(sw, "cap", this.cap.ToString());
            if(this.cmpd !=  ST_CompoundLine.NONE)
                XmlHelper.WriteAttribute(sw, "cmpd", this.cmpd.ToString());
            if(this.algn!= ST_PenAlignment.NONE)
                XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
            sw.Write(">");
            if (this.noFill != null)
                sw.Write("<a:noFill/>");
            if (this.solidFill != null)
                this.solidFill.Write(sw, "solidFill");
            if (this.gradFill != null)
                this.gradFill.Write(sw, "gradFill");
            if (this.pattFill != null)
                this.pattFill.Write(sw, "pattFill");
            if (this.prstDash != null)
                this.prstDash.Write(sw, "prstDash");
            if (this.custDash != null)
            {
                foreach (CT_DashStop x in this.custDash)
                {
                    x.Write(sw, "custDash");
                }
            }
            if (this.round != null)
                sw.Write("<a:round/>");
            if (this.bevel != null)
                sw.Write("<a:bevel/>");
            if (this.miter != null)
                this.miter.Write(sw, "miter");
            if (this.headEnd != null)
                this.headEnd.Write(sw, "headEnd");
            if (this.tailEnd != null)
                this.tailEnd.Write(sw, "tailEnd");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");

            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        public CT_LineProperties()
        {

        }

        [XmlElement(Order = 0)]
        public CT_NoFillProperties noFill
        {
            get
            {
                return this.noFillField;
            }
            set
            {
                this.noFillField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_SolidColorFillProperties solidFill
        {
            get
            {
                return this.solidFillField;
            }
            set
            {
                this.solidFillField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_GradientFillProperties gradFill
        {
            get
            {
                return this.gradFillField;
            }
            set
            {
                this.gradFillField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_PatternFillProperties pattFill
        {
            get
            {
                return this.pattFillField;
            }
            set
            {
                this.pattFillField = value;
            }
        }

        [XmlElement(Order = 4)]
        public CT_PresetLineDashProperties prstDash
        {
            get
            {
                return this.prstDashField;
            }
            set
            {
                this.prstDashField = value;
            }
        }

        [XmlElement(Order = 5)]
        public List<CT_DashStop> custDash
        {
            get
            {
                return this.custDashField;
            }
            set
            {
                this.custDashField = value;
            }
        }

        [XmlElement(Order = 6)]
        public CT_LineJoinRound round
        {
            get
            {
                return this.roundField;
            }
            set
            {
                this.roundField = value;
            }
        }

        [XmlElement(Order = 7)]
        public CT_LineJoinBevel bevel
        {
            get
            {
                return this.bevelField;
            }
            set
            {
                this.bevelField = value;
            }
        }

        [XmlElement(Order = 8)]
        public CT_LineJoinMiterProperties miter
        {
            get
            {
                return this.miterField;
            }
            set
            {
                this.miterField = value;
            }
        }

        [XmlElement(Order = 9)]
        public CT_LineEndProperties headEnd
        {
            get
            {
                return this.headEndField;
            }
            set
            {
                this.headEndField = value;
            }
        }

        [XmlElement(Order = 10)]
        public CT_LineEndProperties tailEnd
        {
            get
            {
                return this.tailEndField;
            }
            set
            {
                this.tailEndField = value;
            }
        }

        [XmlElement(Order = 11)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        public int w
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }

        [XmlIgnore]
        public bool wSpecified
        {
            get
            {
                return this.wFieldSpecified;
            }
            set
            {
                this.wFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_LineCap cap
        {
            get
            {
                return this.capField;
            }
            set
            {
                this.capField = value;
            }
        }

        [XmlIgnore]
        public bool capSpecified
        {
            get
            {
                return ST_LineCap.NONE != capField;
                //return this.capFieldSpecified;
            }
            set
            {
                this.capFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_CompoundLine cmpd
        {
            get
            {
                return this.cmpdField;
            }
            set
            {
                this.cmpdField = value;
            }
        }

        [XmlIgnore]
        public bool cmpdSpecified
        {
            get
            {
                return ST_CompoundLine.NONE != this.cmpdField;
                //return this.cmpdFieldSpecified;
            }
            set
            {
                this.cmpdFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_PenAlignment algn
        {
            get
            {
                return this.algnField;
            }
            set
            {
                this.algnField = value;
            }
        }

        [XmlIgnore]
        public bool algnSpecified
        {
            get
            {
                return ST_PenAlignment.NONE != this.algnField;
                //return this.algnFieldSpecified;
            }
            set
            {
                this.algnFieldSpecified = value;
            }
        }

        public CT_SolidColorFillProperties AddNewSolidFill()
        {
            this.solidFillField = new CT_SolidColorFillProperties();
            return this.solidFillField;
        }
        public bool IsSetSolidFill()
        {
            return this.solidFillField != null;
        }

    }

    
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_LineCap
    {
        NONE,
        /// <remarks/>
        rnd,

        /// <remarks/>
        sq,

        /// <remarks/>
        flat,
    }

    
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_CompoundLine
    {
        NONE,
        /// <remarks/>
        sng,

        /// <remarks/>
        dbl,

        /// <remarks/>
        thickThin,

        /// <remarks/>
        thinThick,

        /// <remarks/>
        tri,
    }

    
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_PenAlignment
    {
        NONE,
        /// <remarks/>
        ctr,

        /// <remarks/>
        @in,
    }
}
