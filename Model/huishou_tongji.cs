using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// huishou_tongji:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class huishou_tongji
    {
        public huishou_tongji()
        { }
        #region Model
        private string _peixunban;
        private string _kecheng;
        private int? _fenzu_id;
        private string _zuming;
        private int? _fenshu_count;
        private int _peixunban_id;
        /// <summary>
        /// 
        /// </summary>
        public string peixunban
        {
            set { _peixunban = value; }
            get { return _peixunban; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string kecheng
        {
            set { _kecheng = value; }
            get { return _kecheng; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? fenzu_id
        {
            set { _fenzu_id = value; }
            get { return _fenzu_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zuming
        {
            set { _zuming = value; }
            get { return _zuming; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? fenshu_count
        {
            set { _fenshu_count = value; }
            get { return _fenshu_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int peixunban_id
        {
            set { _peixunban_id = value; }
            get { return _peixunban_id; }
        }
        #endregion Model

    }
}


