namespace Factory_Method
{
    internal class Fighter : IHumanoid
    {
        public void Build(string typeName)
        {
            Client.Instance.Invoke((MethodInvoker)(() => Client.Instance.ClearImage()));
            Client.Instance.Invoke((MethodInvoker)(() => Client.Instance.ShowMessage(typeName + " створюється...")));
            Task.Delay(2000).Wait();
            Client.Instance.Invoke((MethodInvoker)(() => Client.Instance.ShowMessageWithImage("Створено " + typeName, "Fighter5E.png")));
        }
    }
}
