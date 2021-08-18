export interface EmpleadoResponse {
    id: number,
    nombre: string,
    apellidos: string
    fecha_nacimiento: Date
    fecha_ingreso: Date
    afp: boolean
    cargo_id: number
    nombre_cargo: string
    sueldo: number
}