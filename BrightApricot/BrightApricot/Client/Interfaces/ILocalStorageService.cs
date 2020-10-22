using System;


namespace BrightApricot.Client.Interfaces {


    public interface ILocalStorageService {
        public void StoreString(string value, string key);
        public string GetString(string key);
        public void RemoveString(string key);

        public void StoreObject(object value, string key);
        public T GetObject<T>(string key);
        public void RemoveObject(string key);
    }
}