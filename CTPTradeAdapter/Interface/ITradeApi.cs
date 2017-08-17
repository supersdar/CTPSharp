﻿using CTPCore;
using CTPTradeAdapter.Model;

namespace CTPTradeAdapter.Interface
{
    /// <summary>
    /// 交易接口
    /// </summary>
    public interface ITradeApi
    {
        /// <summary>
        /// 是否已连接
        /// </summary>
        /// <returns></returns>
        bool IsConnected();

        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="callback">连接服务器回调</param>
        /// <param name="brokerID">经纪商代码</param>
        /// <param name="frondAddress">前置服务器地址</param>
        void Connect(DataCallback callback, string brokerID, string frondAddress);

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="callback">断开连接回调</param>
        void Disconnect(DataCallback callback);

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="callback">登录回调</param>
        /// <param name="investorID">投资者账号</param>
        /// <param name="password">密码</param>
        void UserLogin(DataCallback callback, string investorID, string password);

        /// <summary>
        /// 用户登出
        /// </summary>
        /// <param name="callback">登出回调</param>
        void UserLogout(DataCallback callback);

        /// <summary>
        /// 获取交易日
        /// </summary>
        /// <returns></returns>
        string GetTradingDay();

        /// <summary>
        /// 更新用户口令
        /// </summary>
        /// <param name="callback">更新回调</param>
        /// <param name="oldPassword">原密码</param>
        /// <param name="newPassword">新密码</param>
        void UpdateUserPassword(DataCallback callback, string oldPassword, string newPassword);

        /// <summary>
        /// 报单
        /// </summary>
        /// <param name="callback">报单回调</param>
        /// <param name="parameter">报单参数</param>
        void InsertOrder(DataCallback<OrderInfo> callback, OrderParameter parameter);

        /// <summary>
        /// 撤单
        /// </summary>
        /// <param name="callback">撤单回调</param>
        /// <param name="parameter">撤单参数</param>
        void CancelOrder(DataCallback<OrderInfo> callback, CancelOrderParameter parameter);

        /// <summary>
        /// 查询当日委托
        /// </summary>
        /// <param name="callback">查询回调</param>
        void QueryOrder(DataListCallback<OrderInfo> callback);

        /// <summary>
        /// 查询当日成交
        /// </summary>
        /// <param name="callback">查询回调</param>
        void QueryTrade(DataListCallback<TradeInfo> callback);

        /// <summary>
        /// 查询资金账户
        /// </summary>
        /// <param name="callback">查询回调</param>
        void QueryAccount(DataCallback<AccountInfo> callback);

        /// <summary>
        /// 查询持仓
        /// </summary>
        /// <param name="callback">查询回调</param>
        void QueryPosition(DataListCallback<PositionInfo> callback);

        /// <summary>
        /// 预埋单录入
        /// </summary>
        /// <param name="callback">报单回调</param>
        /// <param name="parameter">预埋单参数</param>
        void InsertParkedOrder(DataCallback<ParkedOrderInfo> callback, OrderParameter parameter);

        /// <summary>
        /// 预埋撤单
        /// </summary>
        /// <param name="callback">撤单回调</param>
        /// <param name="parameter"></param>
        void CancelParkedOrder(DataCallback<ParkedOrderInfo> callback, CancelOrderParameter parameter);

        /// <summary>
        /// 查询预埋单
        /// </summary>
        /// <param name="callback">查询回调</param>
        void QueryParkedOrder(DataListCallback<ParkedOrderInfo> callback);

        /// <summary>
        /// 查询预埋撤单
        /// </summary>
        /// <param name="callback">查询回调</param>
        void QueryParkedOrderAction(DataListCallback<ParkedCanelOrderInfo> callback);
    }
}
