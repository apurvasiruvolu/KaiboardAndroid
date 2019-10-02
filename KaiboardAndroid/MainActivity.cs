using System;
using Android.App;
using Android.InputMethodServices;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace KaiboardAndroid
{
    [Service(Permission = "android.permission.BIND_INPUT_METHOD", Label = "Kaiboard")]
    [MetaData("android.view.im", Resource = "@xml/method")]
    [IntentFilter(new string[] { "android.view.InputMethod" })]
    public class MainActivity : InputMethodService, KeyboardView.IOnKeyboardActionListener
    {
        private KeyboardView kv;
        private Keyboard keyboard;
        //private bool isCaps = false;

        public override View OnCreateInputView()
        {
            kv = (KeyboardView)LayoutInflater.Inflate(Resource.Layout.Keyboard, null);
            keyboard = new Keyboard(this, Resource.Xml.qwerty);
            kv.Keyboard = keyboard;
            kv.OnKeyboardActionListener = this;
            return kv;
        }

        public void OnKey([GeneratedEnum] Android.Views.Keycode primaryCode, [GeneratedEnum] Android.Views.Keycode[] keyCodes)
        {
            
        }

        public void OnPress([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
            
        }

        public void OnRelease([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
            
        }

        public void OnText(ICharSequence text)
        {
            
        }

        public void SwipeDown()
        {
            
        }

        public void SwipeLeft()
        {
            
        }

        public void SwipeRight()
        {
            
        }

        public void SwipeUp()
        {
           
        }
    }
}

