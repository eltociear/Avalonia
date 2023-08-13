using System;
using Avalonia.Vulkan.Interop;
using Avalonia.Vulkan.UnmanagedInterop;

namespace Avalonia.Vulkan;

public class VulkanException : Exception
{
    public VulkanException(string message) : base(message)
    {
        
    }
    
    public VulkanException(string funcName, VkResult res) : base($"{funcName} returned {res}")
    {

    }
}

public static class VulkanExceptionExtensions
{
    public static void ThrowOnError(this VkResult res, string funcName)
    {
        if (res != VkResult.VK_SUCCESS)
            throw new VulkanException(funcName, res);
    }
}