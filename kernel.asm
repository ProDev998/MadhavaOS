section .data
    kernel_msg db 'MadhavaOS Kernel Started', 0xa
    kernel_msg_len equ $ - kernel_msg

section .text
global _start

_start:
    ; Print kernel started message
    mov edx, kernel_msg_len
    mov ecx, kernel_msg
    mov ebx, 1  ; File descriptor for stdout
    mov eax, 4  ; Syscall for sys_write
    int 0x80    ; Call kernel

    ; Delay for a short time
    mov eax, 0x3F ; Syscall for sys_nanosleep
    mov ebx, 0    ; No delay in seconds
    mov ecx, 500000000 ; 0.5 second in nanoseconds
    int 0x80

    ; Exit the kernel
    mov eax, 1  ; Syscall for sys_exit
    xor ebx, ebx  ; Exit code 0
    int 0x80    ; Call kernel
