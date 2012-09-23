//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_app_t
    {
        internal cef_base_t _base;
        internal IntPtr _on_before_command_line_processing;
        internal IntPtr _on_register_custom_schemes;
        internal IntPtr _get_resource_bundle_handler;
        internal IntPtr _get_browser_process_handler;
        internal IntPtr _get_render_process_handler;
        internal IntPtr _append_extra_command_line_switches;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int add_ref_delegate(cef_app_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_app_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_refct_delegate(cef_app_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_before_command_line_processing_delegate(cef_app_t* self, cef_string_t* process_type, cef_command_line_t* command_line);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_register_custom_schemes_delegate(cef_app_t* self, cef_scheme_registrar_t* registrar);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_resource_bundle_handler_t* get_resource_bundle_handler_delegate(cef_app_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_browser_process_handler_t* get_browser_process_handler_delegate(cef_app_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_render_process_handler_t* get_render_process_handler_delegate(cef_app_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void append_extra_command_line_switches_delegate(cef_app_t* self, cef_command_line_t* command_line);
        
        private static int _sizeof;
        
        static cef_app_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_app_t));
        }
        
        internal static cef_app_t* Alloc()
        {
            var ptr = (cef_app_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_app_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_app_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
