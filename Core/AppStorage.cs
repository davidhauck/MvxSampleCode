
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Core
{
	public static class AppStorage
	{ 
		static Dictionary<String, object> storedObjects = new Dictionary<String, Object>();

        public static void Empty()
        {
            storedObjects.Clear();
        }

        public static void AddAtKey(String key, Object data)
        {
            if (storedObjects.ContainsKey(key))
            {
                storedObjects[key] = data;
            }
            else
            {
                storedObjects.Add(key, data);
            }
        }

        public static Object GetAtKey(String key)
        {
            return GetAtKey(key, true);
        }

        public static Object GetAtKey(String key, bool isRemove)
        {
            if (storedObjects.ContainsKey(key))
            {
                object data = storedObjects[key];
                if (isRemove)
                {
                    storedObjects.Remove(key);
                }
                return data;
            }
            return null;
        }

        public static void Remove(String key)
        {
            if (storedObjects.ContainsKey(key))
            {
                storedObjects.Remove(key);
            }
        }
	}
}

